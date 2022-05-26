using DPMidTerm.Models;
using DPMidTerm.Data;

namespace DPMidTerm.DesignPattern
{
    public class DrinkTemplate
    {
        protected OrderItem order;
        protected int price;
        protected readonly DataContext _context;

        public DrinkTemplate(DataContext context)
        {
            order = new OrderItem();
            price = 0;
            _context = context;
        }
        public void prepareDink(int productID, ICollection<ToppingItem> toppingItems)
        {
            addDrink(productID);
            addToppings(toppingItems);
            addMilk();
            _context.OrderItems.Add(order);
            _context.SaveChanges();
            calcPrice();
        }
        private void addDrink(int productID)
        {
            order.ProductId = productID;
        }
        private void addToppings(ICollection<ToppingItem> toppingItems)
        {
            foreach (ToppingItem topping in toppingItems)
            {
                order.Toppings.Add(topping);
                _context.ToppingItems.Add(topping);
                _context.SaveChanges();
            }
        }
        public virtual void addMilk()
        {
            ToppingItem toppingItem = new ToppingItem(9, 1);// this is the ID of the milk
            order.Toppings.Add(toppingItem);
            _context.ToppingItems.Add(toppingItem);
            _context.SaveChanges();
        }
        private void calcPrice()
        {
            Product? product = _context.Products.Find(order.ProductId);
            price = product.Price;
            foreach (ToppingItem toppingItem in order.Toppings)
            {
                Topping? topping = _context.Toppings.Find(toppingItem.ToppingId);
                price = price + topping.Price * toppingItem.Quantity;
            }
        }
        public OrderItem getDrink(){
            return order;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
