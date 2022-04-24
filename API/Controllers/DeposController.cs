using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeposController: ControllerBase
    {
        private readonly MikroDbContext _context;
        public DeposController(MikroDbContext contex)
        {
            _context = contex;
        
        }

        [HttpGet]
        public async Task<ActionResult<List<Depo>>> GetDepos()
        {
            var depos = await _context.DEPOLAR.ToListAsync();
            return Ok (depos);
        }
    }
}