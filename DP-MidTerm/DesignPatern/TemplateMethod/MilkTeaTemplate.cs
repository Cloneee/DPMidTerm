using DPMidTerm.Models;
using DPMidTerm.Data;

namespace DPMidTerm.DesignPattern
{
    public class MilkTeaTemplate : DrinkTemplate
    {
        public MilkTeaTemplate(DataContext context) : base(context){}
    }
}