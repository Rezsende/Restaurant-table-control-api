using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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

         var post = new ProductDatail
         {
            Barcode = cad.Barcode,
            Description = cad.Description,
            Qtd = cad.Qtd, 
            Sale_Price = cad.Sale_Price,
            date_Of_Sale = cad.date_Of_Sale,
            commandId = cad.commandId
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
   
      [HttpDelete("{id}")]
      public IActionResult DeletePro(int id)
      {

        var produto = _context.productDatails.Find(id);
        if (produto == null)
        {
            return NotFound("Produto não encontrado");
        }

        _context.productDatails.Remove(produto);
        _context.SaveChanges();

        return Ok("Produto deletado com sucesso");
      }
   
   }
}