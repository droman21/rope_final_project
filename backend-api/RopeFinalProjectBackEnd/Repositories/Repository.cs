using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class Repository<T> where T : class
    {
        private DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Set<T>().Count();
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public virtual void UpdateFields(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }
    }
}
