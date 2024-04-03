using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Restaurant_table_control_api.Context;
using Restaurant_table_control_api.DTO;
using Restaurant_table_control_api.Entity;

namespace Restaurant_table_control_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDatailController : ControllerBase
    {
         private readonly ContextData _context;
         public ProductDatailController(ContextData context)
         {
             _context = context;
         }

         [HttpPost]
         public IActionResult AddProdu([FromBody] ProductDTO cad)
         {
      
            var post = new ProductDatail {
              Description = cad.Description,
              commandId  = cad.commandId
            };
               _context.Add(post);
            _context.SaveChanges();

            return Ok(post);
         }

           [HttpGet]
         public IActionResult ListProdu()
         {
      
            var post = _context.productDatails.ToList();
            
            

            return Ok(post);
         }
    }
}