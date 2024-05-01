using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    
    public class Repository<T> : IRepository<T> where T:class
    {
       protected readonly LibraryDBContext context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public Repository(LibraryDBContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
        }

        /// <summary>
        /// IRepository method implemetation
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Count(Func<T, bool> predicate)
        {
          return  context.Set<T>().Where(predicate).Count();
        }
        protected void Save() => context.SaveChanges();
        public void Create(T entity)
        {
            context.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
            Save();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            context.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
