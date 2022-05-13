using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoAPI2.Models;
using Microsoft.AspNetCore.Authorization;

namespace DemoAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingController : ControllerBase
    {
        private readonly DataContext _context;
        public ToppingController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Topping>>> Get()
        {
            return Ok(await _context.Toppings.ToListAsync());
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Topping>> GetById(int id)
        {
            var topping = await _context.Toppings.FindAsync(id);
            if (topping == null)
            {
                return NotFound("Not found");
            }
            return Ok(topping);
        }
    }
}