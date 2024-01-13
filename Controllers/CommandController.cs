using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_table_control_api.Context;
using Restaurant_table_control_api.DTO;
using Restaurant_table_control_api.Entity;

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

        [HttpPost]
        public IActionResult CreateCommand([FromBody] CommandDTO_Create create)
        {
            var post = new Command
            {
                Description = create.Description
            };

            _context.Add(post);
            _context.SaveChanges();

            return Ok(post);
        }


    }
}