using DPMidTerm.Models;
using DPMidTerm.Data;

namespace DPMidTerm.DesignPattern
{
    public class TeaTemplate : DrinkTemplate
    {
        public TeaTemplate(DataContext context) : base(context){}
        public override void addMilk()
        {
            System.Console.WriteLine("This drink do not have tea");
        }
    }
}