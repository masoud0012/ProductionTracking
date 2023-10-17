using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.FlowProcess;
using OA.Repo.Troual.Contracts.IFlowProcess;
using OA.Service_.Toural.Contracts.FlowProcess;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.FlowProcess;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.FlowProcess
{
    public class FlowUsersSalaryService : IFlowUsersSalaryService
    {
        private readonly IMapper _mapper;
        private readonly IFlowProcessUserSalaryRepository _repository;
        private readonly IProcessUserService _processUserService;
        private readonly IJWService _jwtService;
        public FlowUsersSalaryService(IFlowProcessUserSalaryRepository repository,
                                      IProcessUserService processUserService,
                                                                       IJWService jwtService,
                                      IUserService userService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._processUserService = processUserService;
            this._jwtService = jwtService;
        }

        public FlowProcessVM Active(long id)
        {
            throw new NotImplementedException();
        }

        public FlowProcessVM Edit(FlowProcessDto Entity)
        {
            throw new NotImplementedException();
        }

        public FlowProcessVM GetAll()
        {
            throw new NotImplementedException();
        }

        public FlowProcessVM GetByID(long Id)
        {
            throw new NotImplementedException();
        }

        public FlowProcessVM Insert(FlowProcessDto body, FlowProcessEntity flowProcessEntity)
        {
            var result = new FlowProcessVM();
            try
            {
                if (body.UserSalaryDtos == null || body.UserSalaryDtos.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var users = _processUserService.GetByIDs(body.UserSalaryDtos.Select(z => z.ID).ToArray());
                if (users.hasError == true)
                    throw new CustomErrorException(users.ErrorMessage, users.Code);
                if (users.hasError == true)
                    throw new CustomErrorException(users.ErrorMessage, users.Code, users.ErrorMessages);
                if (users.processUserDtos.Count != body.UserSalaryDtos.Count)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);

                foreach (var item in body.UserSalaryDtos)
                {
                    _repository.Insert(new FlowProcessUserSalaryEntity
                    {
                        CreatedById = this._jwtService.GetUserID(),
                        FlowProcessEntityID = flowProcessEntity.Id,
                        UserID = users.processUserDtos.Where(z => z.UserID == item.UserID).FirstOrDefault().UserID,
                        processUserEntityID = item.ID,
                        SumHours = item.SumHours,
                        SalaryPerHours = item.SalaryPerHours,
                        //TotalPrice = (item.SumHours * Int64.Parse(item.SalaryPerHours)).ToString()
                    });
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

        public FlowProcessVM Insert(FlowProcessDto body, FlowProcessEntity flowProcessEntity, ProcessVM processService)
        {
            var result = new FlowProcessVM();
            try
            {
                if (body.UserSalaryDtos == null || body.UserSalaryDtos.Count <= 0)
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var users = processService.processUserDtos;


                foreach (var item in body.UserSalaryDtos)
                {
                    var userItem = users.Where(z => z.UserID == item.UserID).FirstOrDefault();
                    var FlowProcessUserSalaryEntity = new FlowProcessUserSalaryEntity();
                    if (userItem.SalaryTypeFK_ID == 14)
                    {
                        _repository.Insert(new FlowProcessUserSalaryEntity
                        {
                            CreatedById = this._jwtService.GetUserID(),
                            FlowProcessEntityID = flowProcessEntity.Id,
                            UserID = userItem.UserID,
                            processUserEntityID = item.ID,
                            SumHours = item.SumHours,
                            SalaryPerHours = userItem.salary,
                            TotalPrice = (item.SumHours * Int64.Parse(userItem.salary)).ToString()
                        });
                    }
                    else
                    {
                        _repository.Insert(new FlowProcessUserSalaryEntity
                        {
                            FlowProcessEntityID = flowProcessEntity.Id,
                            CreatedById = this._jwtService.GetUserID(),
                            UserID = userItem.UserID,
                            processUserEntityID = item.ID,
                            SumDays = item.SumHours,
                            SalaryPerDay = userItem.salary,
                            TotalPrice = (item.SumHours * (Int64.Parse(userItem.salary))).ToString()
                        });
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

                throw ex;
            }
            return result;
        }


        public FlowProcessVM Remove(long[] id)
        {
            throw new NotImplementedException();
        }

        public FlowProcessVM Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public FlowProcessVM Search(FlowProcessDto body)
        {
            throw new NotImplementedException();
        }
    }
}
