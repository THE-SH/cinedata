using System.Collections.Generic;

namespace CineDataAPI.Domain.Repository.Interfaces
{
    public interface IRepository<T> {
        List<T> ListAll(bool lazyLoading); 
        T GetById(int id);
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}