using AspNetCoreTestApp.Database.Models;
using System.Collections.Generic;

namespace AspNetCoreTestApp.Services
{
    public interface IRepository<T> where T : class, IHasIdentity
    {
        List<T> GetAllAsync();
        T GetAsync(int id);
        T CreateAsync(T entity);
        void UpdateColumnAsync(string columnName, object newValue);
        void DeleteAsync(int id);
    }
}
