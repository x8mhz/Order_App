using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderApp.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        void Save();
    }
}
