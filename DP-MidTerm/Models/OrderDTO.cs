using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class OrderDTO
    {
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
    }
}
