using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ICollection<ToppingItem> Toppings { get; set; } = new List<ToppingItem>();

    }
}
