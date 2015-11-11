using System.Collections.Generic;

namespace XNOTE.Contracts.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int entity);
        T Find(int id);
        IEnumerable<T> GetAll();
    }
}
