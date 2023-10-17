using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.StockRoom;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Repo.Troual.StockRoomRepository;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Service_.Toural.StockRoom
{
    public class StockRoomService : IStockRoomService
    {
        private readonly IMapper _mapper;
        private readonly IStockRoomRepository _repository;
        private readonly IJWService _jwtService;
        public StockRoomService(IStockRoomRepository repository,
                                IJWService jwtService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }

        public StockRoomVM Assign(StockRoom_InitialBalanceDto dto)
        {
            var stock = _repository.Get(dto.StockRoom_InitialBalanceFK_ID);
            var Entity = new StockRoom_InitialBalanceEntity();
            Entity.StockRoomEntities = stock;
            Entity.Count = dto.Count;
            Entity.IsEnabled = true;
            throw new NotImplementedException();
        }
        private StockRoomEntity GetStockRoomEntity(long ID)
        {
            var entity = _repository.Get(ID);
            if (entity == null)
                throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
            return entity;
        }
        public StockRoomVM Edit(StockRoomDto Entity)
        {
            var result = new StockRoomVM();
            try
            {
                CheckValidation(Entity);
                var entity = GetStockRoomEntity(Entity.ID);
                entity.Title = Entity.Title;
                entity.ModifiedDate = DateTime.Now;
                entity.Description = Entity.Description;
                entity.ModifiedById = _jwtService.GetUserID();
                entity.Address = Entity.Address;
                _repository.Update(entity);
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

        public StockRoomVM GetAll()
        {
            StockRoomVM result = new StockRoomVM();
            var data = _repository.GetALL();
            result.stockRoomDtos = _mapper.Map<List<StockRoomEntity>, List<StockRoomDto>>(data);
            return result;
        }

        public StockRoomVM GetByDto(StockRoomDto body)
        {
            
            throw new NotImplementedException();
        }

        public StockRoomVM GetByID(long ID)
        {
            StockRoomVM result = new StockRoomVM();
            result.stockRoomDto = _mapper.Map<StockRoomEntity, StockRoomDto>(_repository.Get(ID));
            return result;
        }

        public StockRoomVM GetByIDs(long[] ID)
        {
            StockRoomVM result = new StockRoomVM();

            var stocks = _repository.GetQuery(z => ID.Contains(z.Id), 1, 1000, string.Empty).ToList();
            result.stockRoomDtos = _mapper.Map<List<StockRoomEntity>, List<StockRoomDto>>(stocks);
            return result;
        }

        public StockRoomVM Insert(StockRoomDto Entity)
        {
            var result = new StockRoomVM();

            try
            {
                CheckValidation(Entity);
                Entity.IsEnabled = 1;
                Entity.ID = 0;
                
                Entity.Code =CommonUtility.GetParentType(Common.EnumValues.TableEnum.StockCode)+ _repository.LastInsertedID();
                var objEntity = _mapper.Map<StockRoomDto, StockRoomEntity>(Entity);
                objEntity.CreatedById =  _jwtService.GetUserID(); 
                _repository.Insert(objEntity);
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

        private void CheckValidation(StockRoomDto entity)
        {
            if (string.IsNullOrEmpty(entity.Address) || string.IsNullOrEmpty(entity.Title))
                throw new CustomErrorException(ConstantsValue.RequiredMsg,ConstantsValue.RequiredCode);
        }

        public StockRoomVM Remove(long id)
        {
            var result = new StockRoomVM();
            try
            {
                var entity = GetStockRoomEntity(id);
                entity.IsEnabled = false;
                _repository.Update(entity);
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

        public StockRoomVM Active(long id)
        {
            var result = new StockRoomVM();
            try
            {
                var entity = _repository.GetForActive(id);
                if(entity==null)
                    throw new CustomErrorException(ConstantsValue.notFoundMsg, ConstantsValue.notFoundCode);
                entity.IsEnabled = true;
                _repository.Update(entity);
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

        public StockRoomVM Search(StockRoomDto body)
        {
            var result = new StockRoomVM();
            try
            {
                var expression = query(z => ((string.IsNullOrEmpty(body.Title) || z.Title.Contains(body.Title)) ||
                string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title)||
                string.IsNullOrEmpty(body.Title) || z.Code.Contains(body.Title) ||
                string.IsNullOrEmpty(body.Title) || z.Id.ToString().Contains(body.Title)) 
                    &&z.IsEnabled==true);


                var queryResult = _repository.GetQuery(expression, body.Page, body.Row, body.Sort); ;
                var countTable = _repository.GetQuery(expression);

                result.stockRoomDtos = _mapper.Map<List<StockRoomEntity>, List<StockRoomDto>>(queryResult);
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

        private Expression<Func<StockRoomEntity, bool>> query(Expression<Func<StockRoomEntity, bool>> expression)
        {
            return expression;
        }

        private object Expression<T>()
        {
            throw new NotImplementedException();
        }

        public StockRoomVM Remove(long[] id)
        {
            var result = new StockRoomVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = GetStockRoomEntity(item);
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
    }
}
