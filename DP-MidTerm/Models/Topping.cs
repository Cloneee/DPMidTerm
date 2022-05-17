using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class Topping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; } = 0;
    }
}