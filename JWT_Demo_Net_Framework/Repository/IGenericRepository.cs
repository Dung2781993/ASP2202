using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWT_Demo_Net_Framework.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectById(object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}