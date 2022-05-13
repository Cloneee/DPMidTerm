using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DPMidTerm.Models;
using Microsoft.AspNetCore.Authorization;

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
        
    }
}