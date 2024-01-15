using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_table_control_api.Context;
using Restaurant_table_control_api.Entity;

namespace Restaurant_table_control_api.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ContextData _context;

        public ProductController(ContextData context)
        {
            _context = context;
        }

      [HttpGet]
      public IActionResult GetProduct(){ 
        
        var listProduct = _context.Product_Entity.ToList();
        return Ok(listProduct);
        
        }


  
    }
}