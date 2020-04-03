using PlannerN.Entity;
using System.Data.Entity;

namespace PlannerN.Context
{
    class AppContext : DbContext
    {

        public DbSet<Category> categories { get; set; }
        public AppContext(string Dsn) : base(Dsn) { }

    }



}
