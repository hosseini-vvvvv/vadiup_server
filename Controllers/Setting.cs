using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;

namespace server.Controllers
{
    [ApiController]
    [Route("api/setting")]
    public class Setting : ControllerBase
    {
        private readonly StoreContext _context;

        public Setting(StoreContext context)
        {
            _context = context;
        }
        [HttpGet("{key}")]
        public async Task<IActionResult> GetSettingItem(string key)
        {
            var setting = await _context.setting.SingleOrDefaultAsync(s => s.key == key);

            return Ok(setting);
        }




    }
}


