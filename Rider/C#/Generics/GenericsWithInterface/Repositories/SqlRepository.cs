using Microsoft.EntityFrameworkCore;
using Rider.C_.Generics.Entities;

namespace Rider.C_.Generics.GenericsWithInterface.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        
        private readonly DbContext _dbContext;
        
        // T must be reference type to use DbSet
        // That's why we used class with IEntity
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            // return _dbSet.ToList();
            return _dbSet.ToList();
        }

        public void Add(T item)
        {
            
            // Console.WriteLine(item.ToString());
            _dbSet.Add(item);
            _dbContext.SaveChanges();
        }

        public T? GetById(int id)
        {

            // Console.WriteLine(id);
            var item = _dbSet.SingleOrDefault(item => item._id.Equals(id));
            Console.WriteLine(item);
            return item;
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            // Console.WriteLine(_dbSet.Count());
            // foreach (var item in _dbSet)
            // {
            //     Console.WriteLine(item.ToString());
            // }
            // _dbContext.SaveChanges();
        }
    }
}