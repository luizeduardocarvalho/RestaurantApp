using System;
using System.Linq;

namespace RestaurantApp.Domain.Repositories.Core
{
    public interface IRepository<TEntity> : IDisposable
    {
        public bool Insert(TEntity entity);
        public IQueryable<TEntity> Query();

    }
}
