using DPMidTerm.Models;
using DPMidTerm.Data;

namespace DPMidTerm.Functions
{
    public class TeaTemplate : DrinkTemplate
    {
        public TeaTemplate(DataContext context) : base(context){}
        public override void addMilk(){}
    }
}