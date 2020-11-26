using app.domain;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace app.repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly OnionDbContext context;
        private DbSet<T> entities;

        public GenericRepository(OnionDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Create(T entity)
        {
            entities.Add(entity);
        }

        public T Get(Guid id) => entities.Find(id);

        public IQueryable<T> GetAll() => entities;

        public void SaveChanges() => context.SaveChanges();
    }
}