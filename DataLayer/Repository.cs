using DatabaseContext;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly Database context;
        private DbSet<T> entities;
        public Repository(Database context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(Guid id)
        {
            T entity = entities.FirstOrDefault(s => s.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public IEnumerable<T> GetAllByCreatedAt(DateTime dateTime)
        {
            return entities.Where(s => s.CreatedAt == dateTime).AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return entities.FirstOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.SaveChanges();
        }
    }
}
