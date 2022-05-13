using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class ProductDTO
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Price { get; set; } = 0;
    }
}
