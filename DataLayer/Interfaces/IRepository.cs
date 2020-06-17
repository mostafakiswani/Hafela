using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByCreatedAt(DateTime dateTime);
        T GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
