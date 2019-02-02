using AspNetCoreTestApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Services
{
    public class Repository<T> : IRepository<T>
        where T : class, IHasIdentity
    {
        public T CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateColumnAsync(string columnName, object newValue)
        {
            throw new NotImplementedException();
        }
    }
}
