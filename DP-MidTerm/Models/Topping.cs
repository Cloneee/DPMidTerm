using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI2.Models
{
    public class Topping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string Name { get; set; } = String.Empty;
    }
}