using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class ECommerceContext : DbContext
    {
        //public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        }
    }
}
