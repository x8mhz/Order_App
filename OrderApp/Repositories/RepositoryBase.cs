using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderApp.Context;
using OrderApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderApp.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        private readonly OrderAppContext _context;
        private readonly DbSet<T> _db;

        public RepositoryBase(OrderAppContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public void Delete(Guid id)
        {
            var entity = _db.Find(id);
            _db.Remove(entity);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _db.FindAsync(id);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
