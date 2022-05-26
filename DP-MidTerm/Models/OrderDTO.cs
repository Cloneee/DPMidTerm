using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class OrderItemDTO
    {
        public int ProductId { get; set; }
        public ICollection<ToppingItemDTO> Toppings { get; set; }
    }
}
