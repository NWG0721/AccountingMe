using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataLayer.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> where = null);
        public TEntity GetById(object id);
        public void Insert(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
		public void Delete(int id);
		public void Delete(object id);

    }
}
