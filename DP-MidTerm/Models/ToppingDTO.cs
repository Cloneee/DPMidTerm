using System.ComponentModel.DataAnnotations.Schema;

namespace DPMidTerm.Models
{
    public class ToppingDTO
    {
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; } = 0;
    }
}