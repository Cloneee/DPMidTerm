using Microsoft.EntityFrameworkCore;
using DPMidTerm.Models;
namespace DPMidTerm.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> option): base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
