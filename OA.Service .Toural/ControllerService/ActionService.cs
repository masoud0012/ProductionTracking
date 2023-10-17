using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OA.Common.Constants;
using OA.Common.Exceptions;
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
    public class ActionService: IActionService
    {
        private readonly IMapper _mapper;
        private readonly IActionRepository _repository;
        private readonly IControllerRoleRepository _controllerRoleRepository;
        private readonly IActionsUserRepository _actionsUserRepository;
        protected PersmissionActionsVM permissionActions { get; }
        public ActionService(IActionRepository repository,
                                IConfiguration config,
                               IControllerRoleRepository controllerRoleRepository,
                               IActionsUserRepository actionsUserRepository,
                               IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._controllerRoleRepository = controllerRoleRepository;
            this._actionsUserRepository = actionsUserRepository;
        }

        public ControllerVM ChecHasAccess(Int64 userID,Int64 actionsID)
        {
            ControllerVM result = new ControllerVM();
            try
            {
                if (_actionsUserRepository.GetQuery(z => z.UserEntityID == userID && z.ActionsEntityID == actionsID && z.IsEnabled == true)>0)
                {
                    result.Code = ConstantsValue.HasAccessCode;
                    result.ErrorMessage = ConstantsValue.HasAccessMessage;
                }else
                {
                    throw new CustomErrorException(ConstantsValue.NotHasAccessMessage,ConstantsValue.NotHasAccessCode);
                }
            }
            catch(CustomErrorException ex)
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

        public ControllerVM Edit(ActionDto body)
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
                result.ActionDto = _mapper.Map<ActionsEntity, ActionDto>(_repository.Get(ID));
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

        public ControllerVM Search(ActionDto body)
        {
            var result = new ControllerVM();
            try
            {
                var expression = query(z => (z.IsEnabled == true));

                var queryResult = _repository.GetQuery(expression, 1, 1000, string.Empty);
                var countTable = _repository.GetQuery(expression);

                result.ActionDtos = _mapper.Map<List<ActionsEntity>, List<ActionDto>>(queryResult);
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

        private Expression<Func<ActionsEntity, bool>> query(Expression<Func<ActionsEntity, bool>> expression)
        {
            return expression;
        }

        public ControllerVM Insert(ActionDto body)
        {
            var result = new ControllerVM();
            try
            {
                if (string.IsNullOrEmpty(body.Title))
                    throw new CustomErrorException(ConstantsValue.RequiredMsg, ConstantsValue.RequiredCode);
                var childEntity = new ActionsEntity();
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
                var entities = _repository.GetALL();
                var groupPermissionControls = PersmissionActionsDtos.GroupBy(z => z.ControllerName);
                var entitiesGroupBy = entities.GroupBy(z => z.ControllerEntity.ControllerName);
                var data = new List<ActionsEntity>();
                foreach (var entity in entitiesGroupBy)
                {
                    foreach (var item in groupPermissionControls)
                    {
                        if (item.Key == entity.Key)
                        {
                            var itemActions = item.ToList();
                            var entityActions = entity.ToList();
                            foreach (var entityAction in entityActions)
                            {
                                if (!itemActions.Any(z => z.Acttion == entityAction.ActionName))
                                {
                                    data.Add(entityAction);
                                }
                            }

                        }
                    }
                }
                result.ActionDtos =
                    _mapper.Map<List<ActionsEntity>, List<ActionDto>>(data);
                
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

        public ControllerVM GetActionsUser(long userID)
        {
            ControllerVM result = new ControllerVM();
            try
            {
                var actionsUser = _actionsUserRepository.GetQueryData(z => z.UserEntityID == userID&&z.IsEnabled==true).ToList();
                result.ActionDtos = _mapper.Map<List<ActionsEntity>, List<ActionDto>>(actionsUser.Select(z=>z.ActionsEntity).ToList());
                result.ControllerDtos = _mapper.Map<List<ControllerEntity>, List<ControllerDto>>(actionsUser.Select(z => z.ActionsEntity.ControllerEntity).ToList());
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public ControllerVM GetByName(string actionName)
        {
            ControllerVM result = new ControllerVM();
            try
            {
                var entity = _repository.GetQueryData(z => z.ActionName == actionName).FirstOrDefault();
                result.ActionDto = _mapper.Map<ActionsEntity, ActionDto>(entity);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public ControllerVM GrantAccessToUser(int userID)
        {
            ControllerVM result = new ControllerVM();
            try
            {
                if (_actionsUserRepository.GetQuery(z => z.Id > 0) > 0)
                {
                    return result;
                }
                var entity = _repository.GetALL();
                foreach (var item in entity)
                {
                    _actionsUserRepository.Insert(new ActionsUserEntity
                    {
                        ActionsEntityID=item.Id,
                        UserEntityID = userID
                    });
                }
                _actionsUserRepository.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public ControllerVM GetUserGrants(long userID, List<PersmissionActionsDto> PersmissionActionsDtos)
        {
            var result = new ControllerVM();
            try
            {

                var actionsEntity = _actionsUserRepository.GetQueryData(z => z.UserEntityID == userID && z.IsEnabled == true&& z.ActionsEntity.ControllerEntity.IsEnabled==true);

                var groupPermissionControls = PersmissionActionsDtos.GroupBy(z => z.ControllerName);
                var entitiesGroupBy = actionsEntity.GroupBy(z => z.ActionsEntity.ControllerEntity.ControllerName);
                var data = new List<ActionsEntity>();
                foreach (var entity in entitiesGroupBy)
                {
                    foreach (var item in groupPermissionControls)
                    {
                        if (item.Key == entity.Key)
                        {
                            var itemActions = item.ToList();
                            var entityActions = entity.ToList();
                            foreach (var entityAction in entityActions)
                            {
                                if (!itemActions.Any(z => z.Acttion == entityAction.ActionsEntity.ActionName))
                                {
                                    data.Add(entityAction.ActionsEntity);
                                }
                            }

                        }
                    }
                }
                result.ActionDtos = _mapper.Map<List<ActionsEntity>, List<ActionDto>>(data.ToList());

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public ControllerVM SetUserGrants(ActionDto body)
        {
            var result = new ControllerVM();
            try
            {
                var userGranted =  _actionsUserRepository.GetQueryData(z =>z.UserEntityID==body.UserID && z.IsEnabled == true).Select(z=>z.ActionsEntityID).ToArray();
                var wantGranted = body.ActionIDs;
                if (userGranted.Any(z => wantGranted.Contains(z)))
                {
                    var existGrant = wantGranted.Where(z => userGranted.Contains(z)).ToArray();
                    var newGrant = wantGranted.Where(z => !userGranted.Contains(z)).ToArray();
                    var removeGrantIds = userGranted.Where(z => !wantGranted.Contains(z)).ToArray();
                    removeGrant(removeGrantIds, body.UserID);
                    setNewGrant(newGrant, body.UserID);

                }
                else if(!userGranted.Any(z => wantGranted.Contains(z)))
                {
                    removeGrant(userGranted, body.UserID);
                    setNewGrant(wantGranted, body.UserID);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }

        private void removeGrant(long[] ids,long userId)
        {
            var entities = _actionsUserRepository.GetQueryData(z => ids.Contains(z.ActionsEntityID)&&z.UserEntityID==userId&&z.IsEnabled==true).ToList();
            foreach (var item in entities)
            {
                item.IsEnabled = false;
                _actionsUserRepository.Remove(item);
            }
            _actionsUserRepository.SaveChanges();
        }

        private void setNewGrant(long[] ids, long userId)
        {
            var actionEntities = _repository.GetQueryData(z => ids.Contains(z.Id)).ToList();
            foreach (var item in actionEntities)
            {
                var actionUserEntity = new ActionsUserEntity
                {
                    ActionsEntityID=item.Id,
                    UserEntityID = userId,
                };
                _actionsUserRepository.Insert(actionUserEntity);
            }
            _actionsUserRepository.SaveChanges();
        }
    }
}
