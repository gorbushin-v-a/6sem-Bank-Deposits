using Microsoft.EntityFrameworkCore;
using sharps_ent.Context;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace sharps_ent.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(T item)
        {
            ((DbSet<T>)typeof(AppDbContext).GetProperty(typeof(T).Name).GetValue(dbContext)).Add(item);
            dbContext.SaveChanges();
        }
        public IEnumerable<T> Get()
        {
            return ((DbSet<T>)typeof(AppDbContext).GetProperty(typeof(T).Name).GetValue(dbContext));
        }
        public T Get(int id)
        {
            return ((DbSet<T>)typeof(AppDbContext).GetProperty(typeof(T).Name).GetValue(dbContext)).Find(id);
        }
        public void Update(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void Remove(T item)
        {
            ((DbSet<T>)typeof(AppDbContext).GetProperty(typeof(T).Name).GetValue(dbContext)).Remove(item);
            dbContext.SaveChanges();
        }
    }
}
