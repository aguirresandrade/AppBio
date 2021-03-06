﻿using AppBioBackEnd.Infra.Data.Context;
using AppBioBackEnd.Infra.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppBioBackEnd.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected AppBioContext db = new AppBioContext();

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return db.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
