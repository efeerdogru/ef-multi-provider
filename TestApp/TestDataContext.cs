using System.Data.Entity;

namespace TestApp
{
    public class TestDataContext : DbContext
    {
        public TestDataContext() : base("name=TestConnectionString")
        {
            // Disable auto migrations
            Database.SetInitializer<TestDataContext>(null);

            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public virtual DbSet<Table1> Table1 { get; set; }
    }
}