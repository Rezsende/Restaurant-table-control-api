using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_table_control_api.Context;

namespace Restaurant_table_control_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandController : ControllerBase
    {
        private readonly ContextData _context;
        public CommandController(ContextData context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<IActionResult> ListCommand()
        {
            try
            {
                var lista = await _context.Commands_Entity.
              
                Include(t=> t.restaurantTable).Select(c=> new 
                {
                        c.Id,
                        c.Description,
                        restaurantTable = c.restaurantTable != null ? c.restaurantTable.Description : "",
                       
                        

                }).ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}