using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.UserEntity;
using OA.Data.UserEntity;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts.IUser;
using OA.Service_.Toural.Configuration;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.InitialBalance;
using OA.Service_.Toural.ViewModels.ControllVM;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<RoleEntity> _roleManager;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IGeneralParameterService _generalParameterService;
        private readonly IConfiguration _configuration;
        private readonly JwtConfig _jwtConfig;
        private readonly IControllService _controllService;
        private readonly IActionService _actionService;
         public UserService(UserManager<User> userManager, SignInManager<User> signInManager,
                            IControllService controllService,
                            IActionService actionService,
                            IUserRepository userRepository,
                            IMapper mapper,
                            RoleManager<RoleEntity> roleManager,
                            IGeneralParameterService generalParameter,
                            IConfiguration configuration)
        {
            this.userManager = userManager;
            this._mapper = mapper;
            this._actionService = actionService;
            this._controllService = controllService;
            this._generalParameterService = generalParameter;
            this.signInManager = signInManager;
            this._configuration = configuration;
            this._userRepository = userRepository;
            this._roleManager = roleManager;
            _jwtConfig = new JwtConfig
            {
                Secret = configuration[ConfigurationConstants.jwtSecretKey]
            };
        }

        private User Get(Int64 Id)
        {
            var userEntity = userManager.Users.Where(z => z.Id == Id && z.IsEnabled == true).Include(z => z.EmployeerType).Include(z => z.SalaryType).FirstOrDefault();
            if (userEntity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return userEntity;
        }

        public UserVM Active(Int64 Id)
        {
            var result = new UserVM();
            try
            {
                var userEntity = userManager.Users.Where(z => z.Id == Id).FirstOrDefault();
                if (userEntity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                userEntity.IsEnabled = true;
                var operation = userManager.UpdateAsync(userEntity).Result;
                if (operation.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.ValueIsNotValidCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in operation.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);

                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

            return result;
        }

        public UserVM Remove(Int64 Id)
        {
            var result = new UserVM();
            try
            {
                var userEntity = Get(Id);
                userEntity.IsEnabled = false;
                var operation = userManager.UpdateAsync(userEntity).Result;
                if (operation.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.ValueIsNotValidCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in operation.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);

                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public UserVM GetUsers()
        {
            var result = new UserVM();
            try
            {
                result.userDtos = _mapper.Map<List<User>, List<UserDto>>(userManager.Users.Where(z => z.IsEnabled == true).ToList());

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.Message;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public UserVM GetUser(long id)
        {
            var result = new UserVM();
            try
            {
                var userEntity = Get(id);
                result.userDto = _mapper.Map<User, UserDto>(userEntity);
                result.userDto.password = string.Empty;
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }


        private void validationForInsertAndUpdate(UserDto user)
        {

            if (user.SalaryTypeFK_ID != 0)
            {
                var SalaryTypeEntity = _generalParameterService.GetChildByID(user.SalaryTypeFK_ID, ParentEnum.SalaryType);
                if (SalaryTypeEntity.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notFoundSalaryTypeMsg, ConstantsValue.notFoundSalaryTypeCode);
            }
            if (user.EmployeerTypeFK_ID != 0)
            {
                var EmplooyerType = _generalParameterService.GetChildByID(user.EmployeerTypeFK_ID, ParentEnum.EmplooyerType);
                if (EmplooyerType.generalParamterDto == null)
                    throw new CustomErrorException(ConstantsValue.notFoundEmployeeTypeeMsg, ConstantsValue.notFoundEmployeeTypeCode);
            }

            if (!string.IsNullOrEmpty(user.Email))
            {
                if (!CommonUtility.IsValidEmail(user.Email))
                {
                    throw new CustomErrorException(ConstantsValue.notEmailNotValidMsg, ConstantsValue.notEamilNotValidCode);
                }
            }
        }

        public UserVM InsertUser(UserDto user)
        {
            var result = new UserVM();
            try
            {
                if (_userRepository.GetQuery(z => z.UserName.ToLower() == user.UserName) > 0)
                    throw new CustomErrorException(ConstantsValue.userNameDuplicateMsg, ConstantsValue.userNameDuplicateCode);
                var salaryeType = _generalParameterService.GetGeneralParamterByParentCode(ParentEnum.SalaryType);
                if (salaryeType.hasError == true)
                    throw new CustomErrorException(salaryeType.ErrorMessage, salaryeType.Code);
                var salaryTypeDB = salaryeType.generalParamterDtos.Where(z => z.ID == user.SalaryTypeFK_ID).FirstOrDefault();
                validationForInsertAndUpdate(user);
                user.ID = 0;

                var userEntity = _mapper.Map<UserDto, User>(user);
                userEntity.IsEnabled = true;
                if (user.EmployeerTypeFK_ID != 0)
                    userEntity.EmployeerTypeFK_ID = user.EmployeerTypeFK_ID;
                if (user.SalaryTypeFK_ID != 0)
                    userEntity.SalaryTypeFK_ID = user.SalaryTypeFK_ID;
                userEntity.AddedDate = DateTime.Now;
                if (salaryTypeDB.Code == CommonUtility.GetSalaryType(SalaryTypeEnum.PerHour))
                    userEntity.SalaryPerHour = user.SalaryPayment;
                else
                    userEntity.SalaryPerMonth = user.SalaryPayment;
                var newUser = userManager.CreateAsync(userEntity, user.password).Result;
                if (newUser.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync(ConstantsValue.NormalRole).Result)
                    {
                        RoleEntity role = new RoleEntity();
                        role.Name = ConstantsValue.NormalRole;
                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
                        userManager.AddToRoleAsync(userEntity,
                                            ConstantsValue.NormalRole).Wait();
                    }
                    else
                    {
                        userManager.AddToRoleAsync(userEntity,
                                ConstantsValue.NormalRole).Wait();
                    }
                    var jwtToken = GenerateJwtToken(userEntity);
                    result.Code = Common.Constants.ConstantsValue.successCode;
                    result.ErrorMessage = Common.Constants.ConstantsValue.successMessage;
                    result.userDto = new UserDto
                    {
                        Token = jwtToken
                    };
                }
                else
                {
                    result.ErrorMessages = new List<string>();
                    result.Code = ConstantsValue.missingFormatCode;
                    foreach (var item in newUser.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);
                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public UserVM UpdateUser(UserDto user)
        {
            var result = new UserVM();
            try
            {
                validationForInsertAndUpdate(user);
                var SalaryTypeEntity = _generalParameterService.GetByID(user.SalaryTypeFK_ID);
                var EmplooyerType = _generalParameterService.GetByID(user.EmployeerTypeFK_ID);
                var userEntity = Get(user.ID);
                userEntity.FirstName = user.FirstName;
                if (!string.IsNullOrEmpty(user.password))
                    userEntity.PasswordHash = CommonUtility.HashPassword(user.password);

                if (SalaryTypeEntity.generalParamterDto.Code == CommonUtility.GetSalaryType(SalaryTypeEnum.PerHour))
                {
                    userEntity.SalaryPerHour = user.SalaryPayment;
                    userEntity.MaxWorkPerHour = user.MaxWorkPerHour;
                    userEntity.SalaryPerMonth = 0;
                }
                else
                {
                    userEntity.SalaryPerHour = 0;
                    userEntity.SalaryPerMonth = user.SalaryPayment;
                    userEntity.MaxWorkPerDay = user.MaxWorkPerDay;
                }
                userEntity.Code = user.Code;
                userEntity.LastName = user.LastName;
                userEntity.Address = user.Address;
                userEntity.PhoneNumber = user.PhoneNumber;
                userEntity.Description = user.Description;
                userEntity.Mobile = userEntity.Mobile;
                userEntity.Email = user.Email;
                if (userEntity.EmployeerTypeFK_ID != EmplooyerType.generalParamterDto.ID)
                    userEntity.EmployeerTypeFK_ID = EmplooyerType.generalParamterDto.ID;
                if (userEntity.SalaryTypeFK_ID != SalaryTypeEntity.generalParamterDto.ID)
                    userEntity.SalaryTypeFK_ID = SalaryTypeEntity.generalParamterDto.ID;
                var operation = userManager.UpdateAsync(userEntity).Result;
                if (operation.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.ValueIsNotValidCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in operation.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);

                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public UserVM DeleteUser(long id)
        {
            var result = new UserVM();
            try
            {
                var userEntity = Get(id);
                userEntity.IsEnabled = false;
                var operation = userManager.UpdateAsync(userEntity).Result;
                if (operation.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.ValueIsNotValidCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in operation.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);

                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.Message;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public UserVM ChangePassword(UserDto user)
        {
            var result = new UserVM();
            try
            {
                if (string.IsNullOrEmpty(user.password))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var userEntity = Get(user.ID);
                userEntity.PasswordHash = user.password;
                var operation = userManager.UpdateAsync(userEntity).Result;
                if (operation.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.ValueIsNotValidCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in operation.Errors)
                    {
                        result.ErrorMessages.Add(item.Description);

                    }
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public async Task<UserVM> Login(UserDto user)
        {
            UserVM result = new UserVM();
            try
            {
                if ((string.IsNullOrEmpty(user.UserName) && string.IsNullOrEmpty(user.Email)) || string.IsNullOrEmpty(user.password))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var userEntity = await userManager.FindByNameAsync(user.UserName);
                if (userEntity == null)
                    userEntity = await userManager.FindByEmailAsync(user.Email);
                if (userEntity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundUserMsg, ConstantsValue.notFoundUserCode);
                await signInManager.SignOutAsync();
                //if (userManager.Users.Any(z => z.UserName == userEntity.UserName && z.PasswordHash == CommonUtility.HashPassword( user.password)))
                //{
                //    await signInManager.SignInAsync(userEntity,false);
                //}
                SignInResult resultSignIn = await signInManager.PasswordSignInAsync(userEntity.UserName, user.password, false, false);
                if (resultSignIn.Succeeded)
                {
                    _controllService.GrantAccessToUser(1);
                    _actionService.GrantAccessToUser(1);
                    var token = GenerateJwtToken(userEntity);
                    result.userDto = new UserDto
                    {
                        Token = token,
                        FullName=userEntity.FullName,
                        UserName = userEntity.UserName
                    };
                    var userGranted = _actionService.GetActionsUser(userEntity.Id);
                    result.userDto.ControllerDtos = userGranted.ControllerDtos;
                    result.userDto.ActionDtos = userGranted.ActionDtos;
                    result.ErrorMessage = ConstantsValue.successMessage;
                    result.Code = ConstantsValue.successCode;
                }
                else
                    throw new CustomErrorException(ConstantsValue.notFoundUserMsg, ConstantsValue.notFoundUserCode);

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        private string GenerateJwtToken(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())

                }),

                Expires = DateTime.UtcNow.AddDays(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            return jwtToken;
        }

        public UserVM Remove(long[] Id)
        {
            var result = new UserVM();
            try
            {
                foreach (var item in Id)
                {
                    var entity = userManager.FindByIdAsync(item.ToString()).Result;
                    if (entity == null)
                        throw new CustomErrorException(ConstantsValue.notFoundUserMsg, ConstantsValue.notFoundUserCode);

                    entity.IsEnabled = false;
                    var operation = userManager.UpdateAsync(entity).Result;
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        private Expression<Func<User, bool>> query(Expression<Func<User, bool>> expression)
        {
            return expression;
        }

        public UserVM Search(UserDto body)
        {
            var result = new UserVM();
            try
            {
                var expression = query(z => ((string.IsNullOrEmpty(body.Title) || z.FullName.Contains(body.Title)) ||
                                                string.IsNullOrEmpty(body.Title) || z.UserName.Contains(body.Title) ||
                                                string.IsNullOrEmpty(body.Title) || z.Email.Contains(body.Title) ||
                                                string.IsNullOrEmpty(body.Title) || z.PhoneNumber.Contains(body.Title) ||
                                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title))
                                                    && z.IsEnabled == true);

                var queryResult = _userRepository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _userRepository.GetQuery(expression);

                result.userDtos = _mapper.Map<List<User>, List<UserDto>>(queryResult);
                result.numberRows = countTable;
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public UserVM GetUsers(long[] ids)
        {
            var result = new UserVM();
            result.userDtos = new List<UserDto>();
            try
            {
                foreach (var item in ids)
                {
                    var entity = userManager.FindByIdAsync(item.ToString()).Result;
                    if (entity == null)
                        throw new CustomErrorException(ConstantsValue.notFoundUserMsg, ConstantsValue.notFoundUserCode);
                    result.userDtos.Add(_mapper.Map<User, UserDto>(entity));
                }
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }

}
