using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI2.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 0;
        public int Price { get; set;}
        public ICollection<ToppingItem> ToppingItem { get; set; } = new List<ToppingItem>();
}
}
