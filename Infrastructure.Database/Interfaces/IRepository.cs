using System.Collections.Generic;

namespace Infrastructure.Database.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        T Create(T entity);
        T Update(int id, T entity);
        T Remove(int id);
    }
}