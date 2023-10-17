using Microsoft.EntityFrameworkCore;
using OA.Common.Exceptions;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.ProcessRepository
{
    public class ProcessUserRepository : IProcessUserRepository
    {
        private readonly TouralContext context;
        private DbSet<ProcessUserEntity> entities;
        public ProcessUserRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<ProcessUserEntity>();
        }

        public void Delete(ProcessUserEntity entity)
        {
            entities.Remove(entity);
            //SaveChanges();
        }

        public List<ProcessUserEntity> GetQuery(Expression<Func<ProcessUserEntity, bool>> predicate, int Page, int Row)
        {
            return entities.Where(predicate).Skip(Page > 0 ? Row * (Page - 1) : 0).Take(Row).ToList();
        }

        public int GetQuery(Expression<Func<ProcessUserEntity, bool>> predicate)
        {
            return entities.Where(predicate).Count();
        }

        public ProcessUserEntity Get(long id)
        {
            return entities.Where(z => z.Id == id && z.IsEnabled == true).SingleOrDefault();
        }

        public List<ProcessUserEntity> GetByProcessID(long id)
        {
            return entities.Where(z => z.processEntityID == id && z.IsEnabled == true).ToList();
        }

        public List<ProcessUserEntity> GetByIds(long[] id)
        {
            return entities.Where(z => id.Contains(z.Id) && z.IsEnabled == true).ToList();
        }

        public List<ProcessUserEntity> GetALL()
        {
            return entities.Where(z => z.IsEnabled == true).ToList();
        }

        public ProcessUserEntity GetForActive(long id)
        {
            return entities.Where(z => z.Id == id).SingleOrDefault();
        }

        public void Insert(ProcessUserEntity entity)
        {
            entity.IsEnabled = true;
            entity.AddedDate = DateTime.Now;
            entities.Add(entity);
        }

        public void InsertRang(List<ProcessUserEntity> entities)
        {
            entities.AddRange(entities);
        }

        public void Remove(ProcessUserEntity entity)
        {
            entity.IsEnabled = false;
            entities.Update(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(ProcessUserEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void UpdateWithoutSave(ProcessDefinitionEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

        public void UpdateWithoutSave(ProcessUserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
