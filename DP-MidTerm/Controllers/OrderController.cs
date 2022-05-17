using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DPMidTerm.Models;
using Microsoft.AspNetCore.Authorization;
using DPMidTerm.Functions;

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
        public async Task<ActionResult<Order>> Post(OrderDTO order)
        {

            return Ok(new Order());
        }
        [HttpPost("/prepared")]
        [AllowAnonymous]
        public async Task<ActionResult<Order>> Prepared(String drinkName)
        {
            Order order = new Order();
            switch (drinkName)
            {
                case "trà đào":
                    DrinkTemplate drink = new TeaTemplate(_context);
                    ICollection<ToppingItem> toppings = new List<ToppingItem>() { new ToppingItem(7, 1) };
                    drink.prepareDink(2, toppings); // 2 là id của trà đào
                    order.OrderItem.Add(drink.getDrink());
                    order.Price = drink.getPrice();
                    break;
                case "trà ô long":
                    break;
                case "trà sữa ô long":
                    break;
                case "trà sữa truyền thống":
                    break;
                default:
                    return NotFound();
            }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
    }
}