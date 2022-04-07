using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected BikeStoresEntities bikeStoresEntities { get; set; }
        protected DbSet<T> tables = null;

        public GenericRepository()
        {
            bikeStoresEntities = new BikeStoresEntities();
            tables = bikeStoresEntities.Set<T>();
        }

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
            return tables.ToList();
        }

        public T SelectById(object Id)
        {
            try
            {
                return tables.Find(Id);
            } catch(Exception ex)
            {
                return null;
            }
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}