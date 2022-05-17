using DPMidTerm.Models;
using DPMidTerm.Data;

namespace DPMidTerm.Functions
{
    public class MilkTeaTemplate : DrinkTemplate
    {
        public MilkTeaTemplate(DataContext context) : base(context){}
        public override void addMilk()
        {
            ToppingItem toppingItem = new ToppingItem(9, 1);// this is the ID of the milk
            order.Toppings.Add(toppingItem);
            base._context.ToppingItems.Add(toppingItem);
            base._context.SaveChanges();
        }
    }
}