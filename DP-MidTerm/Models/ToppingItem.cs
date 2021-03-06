using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class ToppingItem
    {
        public int Id { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set;}
        public ToppingItem(int toppingId, int quantity)
        {
            ToppingId = toppingId;
            Quantity = quantity;
        }
    }
}