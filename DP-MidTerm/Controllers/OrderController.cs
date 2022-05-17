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
            return Ok(await _context.Orders.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<Order>> Post(OrderDTO order)
        {
            return Ok(new Order());
        }
        [HttpPost("/prepared")]
        public async Task<ActionResult<Order>> Prepared(String drinkName)
        {

            switch (drinkName)
            {
                case "trà đào":
                    break;
                default:
                    return NotFound();
            }
            return new Order();
        }
    }
}