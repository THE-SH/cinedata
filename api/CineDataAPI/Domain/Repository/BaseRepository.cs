using System;
using System.Collections.Generic;
using System.Linq;
using CineDataAPI.Data;
using CineDataAPI.Domain.Entities;
using CineDataAPI.Domain.Repository.Interfaces;
using CineDataAPI.Domain.Validations;
using Microsoft.EntityFrameworkCore;

namespace CineDataAPI.Domain.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _db;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(DataContext context){
            this._db = context;
            this._dbSet = _db.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual List<T> ListAll(bool lazyLoading)
        {
            if(!lazyLoading)
                return _dbSet.AsNoTracking().ToList();
            
            return _dbSet.ToList();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}