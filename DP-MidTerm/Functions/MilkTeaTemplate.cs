using DPMidTerm.Models;

namespace DPMidTerm.Functions
{
    public class MilkTeaTemplate : DrinkTemplate
    {
        public override void prepareDink(int productID, ICollection<ToppingItem> toppingItems)
        {
            addDrink(productID);
            addToppings(toppingItems);
            addMilk();
        }
        private void addMilk(){
            ToppingItem toppingItem = new ToppingItem();
            toppingItem.Id = 9; // this is the ID of the milk
            toppingItem.Quantity = 1;
            order.Toppings.Add(toppingItem);
        }
    }
}