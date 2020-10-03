using System.Collections.Generic;

namespace CineDataAPI.Domain.Repository.Interfaces
{
    public interface IRepository<T> where T : class{
        List<T> ListAll(bool lazyLoading); 
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}