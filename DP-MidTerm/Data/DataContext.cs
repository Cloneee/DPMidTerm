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
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ToppingItem> ToppingItems { get; set; }
    }
}
