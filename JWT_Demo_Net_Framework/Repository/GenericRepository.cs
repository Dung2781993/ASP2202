using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWT_Demo_Net_Framework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SelectAll()
        {
            throw new NotImplementedException();
        }

        public T SelectById(object Id)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}