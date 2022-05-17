using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public int Price { get; set;}
}
}
