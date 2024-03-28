using BaseballAPIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseballAPIs.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        { }
        public DbSet<Player> Player { get; set; }
       
    }
}