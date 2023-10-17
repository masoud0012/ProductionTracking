﻿using OA.Data.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo.Troual.BaseRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        //IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
