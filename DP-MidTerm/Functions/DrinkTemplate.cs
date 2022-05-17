using DPMidTerm.Models;

namespace DPMidTerm.Functions
{
    public abstract class DrinkTemplate
    {
        protected OrderItem order;
        public DrinkTemplate()
        {
            order = new OrderItem();
        }
        public abstract void prepareDink(int productID, ICollection<ToppingItem> toppingItems);
        public void addDrink(int productID)
        {
            order.Id = productID;
        }
        public void addToppings(ICollection<ToppingItem> toppingItems)
        {
            foreach (ToppingItem topping in toppingItems)
            {
                order.Toppings.Add(topping);
            }
        }
        public OrderItem getDrink(){
            return order;
        }
    }
}
