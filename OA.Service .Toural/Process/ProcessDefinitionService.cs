using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Process
{
    public class ProcessDefinitionService : IProcessDefinitionService
    {
        private readonly IMapper _mapper;
        private readonly IProcessDefinitionRepository _repository;
        private readonly IJWService _jwtService;
        public ProcessDefinitionService(IProcessDefinitionRepository repository,
                                          IJWService jwtService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._jwtService = jwtService;
            this._mapper = mapper;
        }



        public ProcessVM Edit(ProcessDefinitionDto generalParamterPoco)
        {

            var result = new ProcessVM();
            try
            {

                var entity = _repository.Get(generalParamterPoco.ID);
                //var parent = _generalParameterRepository.Get(generalParamterPoco.ParentID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
                if (_repository.GetQuery(z => z.Title == generalParamterPoco.Title && z.Id != generalParamterPoco.ID) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                entity.ModifiedById = _jwtService.GetUserID();
                entity.Title = generalParamterPoco.Title;
                entity.Description = generalParamterPoco.Description;
                entity.ModifiedDate = DateTime.Now;
                _repository.Update(entity);
                _repository.SaveChanges();

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

        public ProcessVM GetByID(long ID)
        {
            var result = new ProcessVM();
            try
            {
                result.ProcessDefinitionDto = _mapper.Map<ProcessDefinitionEntity, ProcessDefinitionDto>(_repository.Get(ID));
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


        public ProcessVM Remove(long[] id)
        {
            var result = new ProcessVM();
            try
            {
                var userid = _jwtService.GetUserID(); 
                foreach (var item in id)
                {
                    var entity = _repository.Get(item);
                    entity.IsEnabled = false;
                    entity.ModifiedById = userid;
                }
                _repository.SaveChanges();
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

        public ProcessVM Search(ProcessDefinitionDto body)
        {
            var result = new ProcessVM();
            try
            {

                if (body.Row <= 0)
                    throw new CustomErrorException(ConstantsValue.missingFormatMsg, ConstantsValue.missingFormatCode);

                var expression = query(z => (
                    (string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                        string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                            string.IsNullOrEmpty(body.Title) || z.Description.Contains(body.Title) ||
                                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) &
                                    z.IsEnabled == true);

                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort);
                var countTable = _repository.GetQuery(expression);

                result.processDefinitionDtos = _mapper.Map<List<ProcessDefinitionEntity>, List<ProcessDefinitionDto>>(queryResult);
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

        private Expression<Func<ProcessDefinitionEntity, bool>> query(Expression<Func<ProcessDefinitionEntity, bool>> expression)
        {
            return expression;
        }

        public ProcessVM Insert(ProcessDefinitionDto body)
        {
            var result = new ProcessVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                if (_repository.GetQuery(z => z.Title == body.Title) > 0)
                    throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
                var childEntity = new ProcessDefinitionEntity();
                childEntity.Description = body.Description;
                childEntity.CreatedById = _jwtService.GetUserID();
                childEntity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.ProcessDefinition) + _repository.LastInsertedID();
                childEntity.Title = body.Title;
                childEntity.AddedDate = DateTime.Now;
                _repository.Insert(childEntity);
                _repository.SaveChanges();
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

        public ProcessVM GetAll()
        {
            var result = new ProcessVM();
            try
            {
                result.processDefinitionDtos =
                    _mapper.Map<List<ProcessDefinitionEntity>, List<ProcessDefinitionDto>>(_repository.GetALL());
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

        public ProcessVM Remove(long id)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.Get(id);
                entity.IsEnabled = false;
                entity.ModifiedById = _jwtService.GetUserID();
                _repository.SaveChanges();
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

        public ProcessVM Active(long id)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.GetQuery(z => z.Id == id, 1, 1, string.Empty).FirstOrDefault();
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.IsEnabled = true;
                _repository.SaveChanges();
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
