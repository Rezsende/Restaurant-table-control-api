using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_table_control_api.Context;
using Restaurant_table_control_api.DTO;
using Restaurant_table_control_api.Entity;

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
public IActionResult addProductDetail([FromBody] ProductDatailDTO_post create)
{
    if (create == null)
    {
        return BadRequest("Invalid data received");
    }

    var postcreate = new ProductDetail
    {
        Barcode = create.Barcode,
        Description = create.Description,
        Qtd = create.Qtd,
        Sale_Price = create.Sale_Price,
        DataSales = create.DataSales,
        commandId = create.commandId
    };

    _context.Add(postcreate);
    _context.SaveChanges();

    return Ok(postcreate);
}

  
  
    }
}