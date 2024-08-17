using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataLayer.Services
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private AccountingAppDBContext _db;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(AccountingAppDBContext dbContext)
        {
            _db = dbContext;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }


        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }


        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public void Delete(object id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }

		public void Delete(int id)
		{
            var entity = GetById(id);
            Delete(entity);
		}
	}
}
