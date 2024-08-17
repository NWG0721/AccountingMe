using AccountingMe.DataLayer.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AccountingAppDBContext : DbContext
    {
        public AccountingAppDBContext(DbContextOptions<AccountingAppDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
