using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using System.Reflection.Metadata;


namespace RopeFinalProjectBackEnd.Repositories
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(T entity);
        void Update(T entity);
    }
}
