using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.UserEntity;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Service_.Toural.UserService
{
    public class RoleServices : IRoleServices
    {
        private RoleManager<RoleEntity> _roleManager;
        private IMapper _mapper;

        public RoleServices(RoleManager<RoleEntity> roleManager, IMapper mapper)
        {
            this._roleManager = roleManager;
            this._mapper = mapper;
        }

        public RoleVM Active(long Id)
        {
            var result = new RoleVM();
            try
            {
                var roleEntity = _roleManager.Roles.Where(x => x.Id == Id).ToList().FirstOrDefault();
                if (roleEntity == null)
                    throw new CustomErrorException(Common.Constants.ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                roleEntity.IsEnabled = true;
                var identityResult =   _roleManager.UpdateAsync(roleEntity).Result;
                if (identityResult.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.RequiredCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in identityResult.Errors)
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

        public RoleVM DeleteRole(long id)
        {
            throw new NotImplementedException();
        }

        public RoleVM GetRole(long id)
        {
            var result = new RoleVM();
            try
            {
                result.roleDto = _mapper.Map<RoleEntity, RoleDto>(_roleManager.Roles.Where(x => x.IsEnabled == true).ToList().FirstOrDefault());
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

        public RoleVM GetRoles()
        {
            var result = new RoleVM();
            try
            {
                result.roleDtos = _mapper.Map<List<RoleEntity>, List<RoleDto>>(_roleManager.Roles.Where(x => x.IsEnabled == true).ToList());
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

        public RoleVM InsertRole(RoleDto role)
        {
            var result = new RoleVM();
            try
            {
                if (string.IsNullOrEmpty(role.Name))
                    throw new CustomErrorException(Common.Constants.ConstantsValue.RequiredCode, ConstantsValue.RequiredMsg);
                var roleEntity = _roleManager.Roles.Where(x => x.IsEnabled == true&&x.Name.ToLower()==role.Name.ToLower()).ToList().FirstOrDefault();
                if (roleEntity != null)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);

                var RoleEntity = _mapper.Map<RoleDto, RoleEntity>(role);
                RoleEntity.Id = 0;
                var identityResult = _roleManager.CreateAsync(RoleEntity).Result;
                if (identityResult.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.RequiredCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in identityResult.Errors)
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

        public RoleVM Remove(long Id)
        {
            var result = new RoleVM();
            try
            {
                var roleEntity = _roleManager.Roles.Where(x => x.IsEnabled == true).ToList().FirstOrDefault();
                if (roleEntity == null)
                    throw new CustomErrorException(Common.Constants.ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                roleEntity.IsEnabled = false;
                var identityResult = _roleManager.UpdateAsync(roleEntity).Result;

                if (identityResult.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.RequiredCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in identityResult.Errors)
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

        public RoleVM UpdateRole(RoleDto role)
        {
            var result = new RoleVM();
            try
            {
                var roleEntity = _roleManager.Roles.Where(x => x.IsEnabled == true && x.Id == role.Id).ToList().FirstOrDefault();
                if (roleEntity == null)
                    throw new CustomErrorException(Common.Constants.ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                if (string.IsNullOrEmpty(role.Name))
                    throw new CustomErrorException(Common.Constants.ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var roleEntity1 = _roleManager.Roles.Where(x => x.IsEnabled == true && x.Name.ToLower() == role.Name.ToLower()&&x.Id!=role.Id).ToList().FirstOrDefault();
                if (roleEntity1 != null)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                roleEntity.Name = role.Name;
                var identityResult = _roleManager.UpdateAsync(roleEntity).Result;

                if (identityResult.Succeeded)
                {
                    result.Code = ConstantsValue.successCode;
                    result.ErrorMessage = ConstantsValue.successMessage;
                }
                else
                {
                    result.Code = ConstantsValue.RequiredCode;
                    result.ErrorMessages = new List<string>();
                    foreach (var item in identityResult.Errors)
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

    }
}
