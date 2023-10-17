using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.StockRoom;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repo.Troual.StockRoomRepository
{
    public class StockRoom_InitialBalanceRepository :  IStockRoom_InitialBalanceRepository
    {
        private readonly TouralContext context;
        private DbSet<StockRoom_InitialBalanceEntity> entities;
        public StockRoom_InitialBalanceRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<StockRoom_InitialBalanceEntity>();
        }

        public bool ChecIsValidAssign(long stockID,Int64 balanceID,long count,long availableCount)
        {
            var entity = entities.Where(z => z.StockRoom_InitialBalanceFK_ID == stockID && z.StockRoom_InitialBalanceFK_ID == balanceID).FirstOrDefault();
            if (entity != null)
            {
                if (count < availableCount)
                    throw new CustomErrorException(ConstantsValue.assignBalanceCode, ConstantsValue.assignBalanceMsg);
                if (availableCount - entity.Count < count)
                {
                    string msg = "قبلا مقدار" + entity.Count + "تخصیص داده شده است." + "در حال حاضر حداکثر امکان تخصیص " + (availableCount - entity.Count).ToString() + " وجود دارد";
                    throw new CustomErrorException(ConstantsValue.assignBalanceCode, msg);
                }

            }
            else
                return true;
            return true;
        }

        public bool ChecIsAssigned(long stockID, Int64 balanceID)
        {
            var entity = entities.Where(z => z.StockRoom_InitialBalanceFK_ID == stockID && z.InitialBalanceEntitiesFK_ID == balanceID && z.IsEnabled == true).FirstOrDefault();
            if (entity != null)//قبلا تخصیص داده شده است
                return false;
            else
                return true;
        }


        public StockRoom_InitialBalanceEntity GetByBalanceIDStockID(long stockID, Int64 balanceID)
        {
            var entity = entities.Where(z => z.StockRoom_InitialBalanceFK_ID == stockID && z.InitialBalanceEntitiesFK_ID == balanceID && z.IsEnabled == true).ToList();
            return entity.FirstOrDefault();
        }
        public long CalcAssignedBefore( Int64 balanceID)
        {
            return entities.Where(z=>z.InitialBalanceEntitiesFK_ID==balanceID && z.IsEnabled == true).Sum(z => z.Count);
        }



        public long CalcAssignedBeforeForUpdate(Int64 balanceID,Int64 StockID)
        {
            return entities.Where(z => z.InitialBalanceEntitiesFK_ID == balanceID&&z.StockRoom_InitialBalanceFK_ID!=StockID && z.IsEnabled == true).Sum(z => z.Count);
        }

        public void Delete(StockRoom_InitialBalanceEntity entity)
        {
            entities.Remove(entity);
            SaveChanges();
        }

        public StockRoom_InitialBalanceEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public StockRoom_InitialBalanceEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id ).SingleOrDefault();
        }

        public StockRoom_InitialBalanceEntity FindAllByID(long id)
        {
            return entities.Where(z => z.Id == id&&z.IsEnabled==true).SingleOrDefault();
        }

        public List<StockRoom_InitialBalanceEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public void Insert(StockRoom_InitialBalanceEntity entity)
        {
            entity.IsEnabled = true;
            entities.Add(entity);
        }

        public void Remove(StockRoom_InitialBalanceEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(StockRoom_InitialBalanceEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public void Insert(List<StockRoom_InitialBalanceEntity> entity)
        {
            entities.AddRange(entity);
        }

        public List<StockRoom_InitialBalanceEntity> Get(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id)).ToList();
        }
    }
}
