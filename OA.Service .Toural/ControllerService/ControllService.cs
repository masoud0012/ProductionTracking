using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.ControllersEntity;
using OA.Repo.Troual.Contracts.IController;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.ViewModels;
using OA.Service_.Toural.ViewModels.ControllVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ControllerService
{
    public class ControllService: IControllService
    {
        private readonly IMapper _mapper;
        private readonly IControllerRepository _repository;
        private readonly IControllerRoleRepository _controllerRoleRepository;
        private readonly IControllerUserRepository _controllerUserRepository;
        public ControllService(IControllerRepository repository,
                               IControllerRoleRepository controllerRoleRepository,
                               IControllerUserRepository controllerUserRepository,
                               IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._controllerRoleRepository = controllerRoleRepository;
            this._controllerUserRepository = controllerUserRepository;
        }



        public ControllerVM Edit(ControllerDto body)
        {

            var result = new ControllerVM();
            try
            {

                var entity = _repository.Get(body.ID);
                //var parent = _generalParameterRepository.Get(generalParamterPoco.ParentID);
                if (entity == null)
                    throw new CustomErrorException(ConstantsValue.notFoundCode, ConstantsValue.notFoundMsg);
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

        public ControllerVM GetByID(long ID)
        {
            var result = new ControllerVM();
            try
            {
                result.ControllerDto = _mapper.Map<ControllerEntity, ControllerDto>(_repository.Get(ID));
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


        public ControllerVM Remove(long[] id)
        {
            var result = new ControllerVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = _repository.Get(item);
                    entity.IsEnabled = false;
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

        public ControllerVM Search(ControllerDto body)
        {
            var result = new ControllerVM();
            try
            {
                var expression = query(z => (z.IsEnabled == true));

                var queryResult = _repository.GetQuery(expression, 1,1000, string.Empty);
                var countTable = _repository.GetQuery(expression);

                result.ControllerDtos = _mapper.Map<List<ControllerEntity>, List<ControllerDto>>(queryResult);
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

        private Expression<Func<ControllerEntity, bool>> query(Expression<Func<ControllerEntity, bool>> expression)
        {
            return expression;
        }

        public ControllerVM Insert(ControllerDto body)
        {
            var result = new ControllerVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var childEntity = new ControllerEntity();
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

        public ControllerVM GetAll(List<PersmissionActionsDto> PersmissionActionsDtos)
        {
            var result = new ControllerVM();
            try
            {
                result.ControllerDtos =
                    _mapper.Map<List<ControllerEntity>, List<ControllerDto>>(_repository.GetALL());
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

        public ControllerVM Remove(long id)
        {
            var result = new ControllerVM();
            try
            {
                var entity = _repository.Get(id);
                entity.IsEnabled = false;
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

        public ControllerVM Active(long id)
        {
            var result = new ControllerVM();
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

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public ControllerVM GetByName(string controllerName)
        {
            var result = new ControllerVM();
            try
            {
                var controllerEntity = _repository.GetQuery(z => z.ControllerName == controllerName && z.IsEnabled == true, 1, 100, "").FirstOrDefault();
                result.ControllerDto = _mapper.Map<ControllerEntity, ControllerDto>(controllerEntity);
                if (controllerEntity.ActionsEntities != null)
                    result.ControllerDto.ActionDtos = _mapper.Map<List<ActionsEntity>, List<ActionDto>>(controllerEntity.ActionsEntities);
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

        public ControllerVM GetController(long userID)
        {
            var result = new ControllerVM();
            try
            {
                var controllers = _controllerUserRepository.GetQueryData(z => z.UserEntityID == userID).ToList();
                result.ControllerDtos = _mapper.Map<List<ControllerEntity>, List<ControllerDto>>(controllers.Select(z=>z.ControllerEntity).ToList());
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        public ControllerVM GrantAccessToUser(Int64 userID)
        {
            ControllerVM result = new ControllerVM();
            try
            {
                if (_controllerUserRepository.GetQuery(z => z.Id > 0) > 0)
                {
                    return result;
                }
                var entity = _repository.GetALL();
                foreach (var item in entity)
                {
                    _controllerUserRepository.Insert(new ControllerUserEntity
                    {
                        ControllerEntityID = item.Id,
                        UserEntityID = userID
                    });
                }
                _controllerUserRepository.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public ControllerVM GetUserGrants(long userID)
        {
            var result = new ControllerVM();
            try
            {

                var controlsEntity = _controllerUserRepository.GetQueryData(z=>z.UserEntityID==userID&&z.IsEnabled==true);
                result.ControllerDtos = _mapper.Map<List<ControllerEntity>,List<ControllerDto>>(controlsEntity.Select(z => z.ControllerEntity).ToList());

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
