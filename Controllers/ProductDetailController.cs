using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_table_control_api.Context;

namespace Restaurant_table_control_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductDetailController: ControllerBase
    {
        private readonly ContextData _context;
        public ProductDetailController(ContextData context)
        {
            _context = context;            
        }

              
      [HttpGet]
      public IActionResult GetProductDetail(){ 
        
        var listProduct = _context.ProductDetails_Entity.Select(p=> new  {

           id = p.Id,
           qtd = p.Qtd,
           dataSales = p.DataSales,
          
    

        }).ToList();
        return Ok(listProduct);
        
        }


     [HttpPost]
     public IActionResult addProductDetail()
     {
        return Ok();
     }
  
  
  
    }
}