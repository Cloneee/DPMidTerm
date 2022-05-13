using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI2.Models
{
    public class OrderDTO
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 0;
        public ICollection<ToppingItem> Toppings { get; set; } = new List<ToppingItem>();
}
}
