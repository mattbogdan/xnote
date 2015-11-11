using System.Collections.Generic;
using System.Data.Entity;
using XNOTE.Contracts.Repositories;

namespace XNOTE.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly XnoteContext context;
        protected internal DbSet<T> Entities
        {
            get { return context.Set<T>(); }
        }
        public Repository(XnoteContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.Entities.Add(entity);
            this.context.SaveChanges();
        }
        public void Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = Find(id);
            this.Entities.Remove(entity);
            this.context.SaveChanges();
        }
        public T Find(int id)
        {
            return this.Entities.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return this.Entities;
        }   
    }
}