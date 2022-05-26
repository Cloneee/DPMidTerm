using DPMidTerm.Models;

namespace DPMidTerm.DesignPattern
{
    public  class DrinkBuilder
    {
        protected OrderItem _orderItem = new OrderItem();
        public virtual void addTea(){}
        public void addToppings(ICollection<ToppingItemDTO> toppingItems)
        {
            foreach (ToppingItemDTO toppingItem in toppingItems)
            {
                _orderItem.Toppings.Add(new ToppingItem(toppingItem.ToppingId, toppingItem.Quantity));
            }
        }
        public OrderItem getDrink()
        {
            return _orderItem;
        }
    }
}