using System.Data.Entity;

namespace DAL
{
    public class Exer1DbContext : DbContext
    {
        public Exer1DbContext() : base("name=MyConn") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}