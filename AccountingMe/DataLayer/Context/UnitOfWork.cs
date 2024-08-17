using AccountingMe.DataLayer.Entites;
using DataLayer.Services;


namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly AccountingAppDBContext _db;

        public UnitOfWork(AccountingAppDBContext context)
        {
            _db = context;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        private GenericRepository<User> _genericRepository;

        public GenericRepository<User> UsersRepository
        {
            get
            {
                if (_genericRepository == null)
                {
                    _genericRepository = new GenericRepository<User>(_db);
                }
                return _genericRepository;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
