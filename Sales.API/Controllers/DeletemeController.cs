using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DeletemeController : Controller
    {
        private readonly DataContext _context;

        public DeletemeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Deletemes.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Deleteme deleteme)
        {
            deleteme.Id = Guid.NewGuid();
            _context.Add(deleteme);
            await _context.SaveChangesAsync();
            return Ok(deleteme);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Deleteme deleteme)
        {
            var currentDeleteme = await _context.Deletemes.FirstOrDefaultAsync(d => d.Id == deleteme.Id);
            if (currentDeleteme == null) 
            {
                return NotFound();
            }
            currentDeleteme.Name = deleteme.Name;
            await _context.SaveChangesAsync();
            return Ok(currentDeleteme);
        }
    }
}
