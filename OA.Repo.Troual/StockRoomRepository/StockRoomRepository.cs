using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Data.Toural.StockRoom;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repo.Troual.StockRoomRepository
{
    public class StockRoomRepository :  IStockRoomRepository
    {
        private readonly TouralContext context;
        private DbSet<StockRoomEntity> entities;
        public StockRoomRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<StockRoomEntity>();
        }

        public void Delete(StockRoomEntity entity)
        {
            entities.Remove(entity);
            SaveChanges();
        }

        public List<StockRoomEntity> GetQuery(Expression<Func<StockRoomEntity, bool>> predicate, int Page, int Row, string orderBy)
        {
            var orderModel = OrderModelUtility.Order(orderBy);
            return entities.Where(predicate).OrderByPropertyName(orderModel.orderParam, orderModel.asc).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }
        public int GetQuery(Expression<Func<StockRoomEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public StockRoomEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<StockRoomEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public StockRoomEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public void Insert(StockRoomEntity entity)
        {
            //if (entities.Any(z => z.Code == entity.Code))
            //    throw new CustomErrorException(ConstantsValue.DuplicateMsg, ConstantsValue.DuplicateCode);
            if(entities.Any(z=>z.Title==entity.Title))
                throw new CustomErrorException(ConstantsValue.DuplicateNameMsg, ConstantsValue.DuplicateNameCode);
            entity.AddedDate = DateTime.Now;
            entity.ModifiedDate = entity.AddedDate;
            entity.Code = CommonUtility.GetParentType(Common.EnumValues.TableEnum.StockCode) + LastInsertedID();
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(StockRoomEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(StockRoomEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            if(entities.Any(z=>z.Id!=entity.Id&& z.Title == entity.Title))
                throw new CustomErrorException(ConstantsValue.DuplicateNameCode, ConstantsValue.DuplicateNameMsg);
            entity.ModifiedDate = DateTime.Now;
            context.SaveChanges();
        }

        public void UpdateWithoutSave(StockRoomEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public long LastInsertedID()
        {
            var entity = entities.FirstOrDefault();
            if (entity == null)
                return 99;
            return (entities.OrderByDescending(z => z.Id).Last().Id) +100;
        }

        public StockRoomEntity GetLastItem(Int64 UserID)
        {
            return entities.OrderByDescending(p => p.ModifiedDate).FirstOrDefault(z => z.CreatedById == UserID || z.ModifiedById == UserID);
        }
    }
}
