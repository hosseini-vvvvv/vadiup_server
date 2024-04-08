using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;

namespace server.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class Category : ControllerBase
    {
        private readonly StoreContext _context;
        public Category(StoreContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<Category>>> getCategory()
        {
            var category = await _context.category.ToListAsync();
            return Ok(category);
        }
    }
}
