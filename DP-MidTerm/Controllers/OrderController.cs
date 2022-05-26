using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DPMidTerm.Models;
using Microsoft.AspNetCore.Authorization;
using DPMidTerm.DesignPattern;

namespace DPMidTerm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;
        public OrderController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
            return Ok(_context.Orders
                        .Include(order => order.OrderItem)
                            .ThenInclude(orderItem => orderItem.Toppings));
        }
        [HttpPost]
        public async Task<ActionResult<Order>> Post(ICollection<OrderItemDTO> request)
        {
            Order order = new Order();
            foreach (var orderItem in request)
            {
                DrinkBuilder builder;
                switch (orderItem.ProductId)
                {
                    case 1:
                        builder = new OlongBuilder();
                        break;
                    case 2:
                        builder = new PeachTeaBuilder();
                        break;
                    case 3:
                        builder = new MatchaBuilder();
                        break;
                    default:
                        return NotFound();
                }
                builder.addTea();
                builder.addToppings(orderItem.Toppings);
                order.OrderItem.Add(builder.getDrink());
            }
            order.Price = calcPrice(order);
            _context.Orders.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }
        [HttpPost("/prepared")]
        [AllowAnonymous]
        public async Task<ActionResult<Order>> Prepared(String drinkName)
        {
            Order order = new Order();
            DrinkTemplate drink;
            ICollection<ToppingItem> toppings = new List<ToppingItem>();
            switch (drinkName)
            {
                case "trà đào":
                    int ID_DAO_TOPPING = 7;
                    toppings = new List<ToppingItem>() { new ToppingItem(ID_DAO_TOPPING, 1) };
                    drink = new TeaTemplate(_context);
                    drink.prepareDink(2, toppings); // 2 là id của trà đào
                    order.OrderItem.Add(drink.getDrink());
                    order.Price = drink.getPrice();
                    break;
                case "trà ô long":
                    drink = new TeaTemplate(_context);
                    drink.prepareDink(1, toppings); // 1 là id của trà ô long;
                    order.OrderItem.Add(drink.getDrink());
                    order.Price = drink.getPrice();
                    break;
                case "trà sữa ô long":
                    int ID_TRAN_CHAU_TOPPING = 1;
                    drink = new MilkTeaTemplate(_context);
                    toppings = new List<ToppingItem>() { new ToppingItem(ID_TRAN_CHAU_TOPPING, 1) };
                    drink.prepareDink(1, toppings); // 1 là id của trà ô long;
                    order.OrderItem.Add(drink.getDrink());
                    order.Price = drink.getPrice();
                    break;
                default:
                    return NotFound();
            }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
        private int calcPrice(Order order)
        {
            int price = 0;
            foreach(OrderItem item in order.OrderItem)
            {
                Product product = _context.Products.Find(item.ProductId);
                price += product.Price;
                foreach(ToppingItem toppingItem in item.Toppings)
                {
                    Topping topping = _context.Toppings.Find(toppingItem.ToppingId);
                    price += topping.Price*toppingItem.Quantity;
                }
            }
            return price;
        }
    }
}