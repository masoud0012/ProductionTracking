using AutoMapper;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.InitialBalance;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Service_.Toural.InitialBalance
{
    public class GeneralParameterService : IGeneralParameterService
    {
        private readonly IMapper _mapper;
        private readonly IJWService _jwtService;
        private readonly IGeneralParameterRepository _generalParameterRepository;
        public GeneralParameterService(IGeneralParameterRepository generalParameterRepository,
             IJWService jwtService,
            IMapper mapper)
        {
            this._generalParameterRepository = generalParameterRepository;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }

        private GeneralParameter GetGeneralParameter(long id)
        {
            var entity = _generalParameterRepository.GetChildById(id);
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;
        }

        public InitialBalanceVM Edit(GeneralParamterPoco generalParamterPoco)
        {

            var result = new InitialBalanceVM();
            try
            {

                var entity = GetGeneralParameter(generalParamterPoco.ID);
                //var parent = _generalParameterRepository.Get(generalParamterPoco.ParentID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                
                if (_generalParameterRepository.GetQuery(z => z.Title == generalParamterPoco.Title && z.Id != generalParamterPoco.ID&&z.ParentID==entity.ParentID && z.IsEnabled == true) != 0)
                {
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                }
                entity.Title = generalParamterPoco.Title;
                entity.Description = generalParamterPoco.Description;
                if (entity.CreatedById == 0)
                    entity.CreatedById = _jwtService.GetUserID();
                entity.ModifiedById = _jwtService.GetUserID();
                //if (parent != null)
                //    entity.ParentID = parent.Id;
                _generalParameterRepository.Update(entity);
                _generalParameterRepository.SaveChanges();
                result.generalParamterDto = _mapper.Map<GeneralParameter, GeneralParamterPoco>(entity);
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

        public InitialBalanceVM GetByID(long ID)
        {
            var result = new InitialBalanceVM();
            try
            {
                result.generalParamterDto = _mapper.Map<GeneralParameter, GeneralParamterPoco>(_generalParameterRepository.Get(ID));
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

        public InitialBalanceVM GetChildByID(long ID, ParentEnum parentEnum)
        {
            var result = new InitialBalanceVM();
            try
            {
                result.generalParamterDto = _mapper.Map<GeneralParameter, GeneralParamterPoco>(_generalParameterRepository.GetChild(ID, parentEnum));
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
        public InitialBalanceVM GetGeneralParamterByParentCode(ParentEnum Parent)
        {
            var result = new InitialBalanceVM();
            try
            {
                var parent = _generalParameterRepository.GetGeneralParamterByParentCode(CommonUtility.GetParentType(Parent));
                var dto = _mapper.Map<GeneralParamterPoco>(parent.FirstOrDefault());
                result.generalParamterDtos = _mapper.Map<List<GeneralParameter>, List<GeneralParamterPoco>>(parent);
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

        public InitialBalanceVM GetGeneralParamters()
        {
            var result = new InitialBalanceVM();
            try
            {
                var parents = _generalParameterRepository.GetParametersParents();
                result.generalParamterDtos = _mapper.Map<List<GeneralParameter>, List<GeneralParamterPoco>>(parents);
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



        public InitialBalanceVM Remove(long[] id)
        {
            var result = new InitialBalanceVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = _generalParameterRepository.GetById(item);
                    entity.ModifiedById = _jwtService.GetUserID();
                    entity.IsEnabled = false;
                }
                _generalParameterRepository.SaveChanges();
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

        public InitialBalanceVM Search(GeneralParamterPoco body)
        {
            var result = new InitialBalanceVM();
            try
            {

                var parentEntity = _generalParameterRepository.GetParentByCode(body.ParentCode);
                if (parentEntity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                if (body.Row <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);

                var expression = query(z => (
                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                        string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                            string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                            z.ParentID == parentEntity.Id && z.IsEnabled == true);

                var queryResult = _generalParameterRepository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _generalParameterRepository.GetQuery(expression);

                result.generalParamterDtos = _mapper.Map<List<GeneralParameter>, List<GeneralParamterPoco>>(queryResult);
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

        private Expression<Func<GeneralParameter, bool>> query(Expression<Func<GeneralParameter, bool>> expression)
        {
            return expression;
        }

        public InitialBalanceVM Insert(GeneralParamterPoco body)
        {
            var result = new InitialBalanceVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title)||string.IsNullOrEmpty(body.Code))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var parentCode = CommonUtility.GetValueFromDescription<ParentEnum>(body.Code);
                var ParentEntity = _generalParameterRepository.GetParentByCodeStr(body.Code);
                var childEntities = _generalParameterRepository.GetChildByParentID(ParentEntity.Id);
                if (childEntities.Any(z => z.Title == body.Title))
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                string order = "date:desc";
                var lastEntity = _generalParameterRepository.GetQuery(z => z.ParentID == ParentEntity.Id, 1, 1, order).Last();


                var childEntity = new GeneralParameter();
                childEntity.CreatedById = _jwtService.GetUserID();
                childEntity.Parent = ParentEntity;
                childEntity.Code =ParentEntity.Code+ CommonUtility.generateCodeForGeneralParams(lastEntity.Code.Substring(4, 4));
                childEntity.Description = body.Description;
                childEntity.Title = body.Title;
                childEntity.AddedDate = DateTime.Now;
                childEntity.IsEnabled = true;
                _generalParameterRepository.Insert(childEntity);
                _generalParameterRepository.SaveChanges();
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

        public InitialBalanceVM GetAll()
        {
            var result = new InitialBalanceVM();
            try
            {
                result.generalParamterDtos =
                    _mapper.Map<List<GeneralParameter>, List<GeneralParamterPoco>>(_generalParameterRepository
                        .GetGeneralParameters());
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

        private string generateCode(long parentID)
        {
            var entity = _generalParameterRepository.GetQuery(z => z.ParentID == parentID, 1, 1, string.Empty).OrderBy(z=>z.Id).FirstOrDefault();
            string childParent = entity.Code.Substring(4,4);
            int number = Int32.Parse(childParent) + 1;
            string result = string.Empty;
            if (number < 10)
                result = "000" + number;
            else if (number < 100)
                result = "00" + number;
            else if (number < 1000)
                result = "0" + number;
            else if (number < 10000)
                result = "0" + number;
            return result;
        }

        public InitialBalanceVM GetGeneralParamters(string[] Codes)
        {
            var result = new InitialBalanceVM();
            try
            {
                foreach (var item in Codes)
                {
                    var parent = _generalParameterRepository.GetParentByCode(item);
                    if (parent != null)
                    {
                        var child = _generalParameterRepository.GetChildByParentID(parent.Id);
                        var dto = _mapper.Map<List<GeneralParameter>, List<GeneralParamterPoco>>(child);
                        if (result.generalParamterDtos == null)
                            result.generalParamterDtos = new List<GeneralParamterPoco>();
                        result.generalParamterDtos.AddRange(dto);
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

        public int getCurrentDaysOfMonth()
        {
            return PersianDateTime.GetDaysInMonth(PersianDateTime.Now.Year, PersianDateTime.Now.Month);
        }
    }
}
