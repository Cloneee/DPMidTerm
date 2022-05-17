using DPMidTerm.Models;

namespace DPMidTerm.Functions
{
    public class TeaTemplate : DrinkTemplate
    {
        public override void prepareDink(int productID, ICollection<ToppingItem> toppingItems)
        {
            addDrink(productID);
            addToppings(toppingItems);
        }
    }
}