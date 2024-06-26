using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
        public IActionResult postCommand([FromBody] CommandDto cad)
        {

            var post = new Command
            {
                Description = cad.Description
            };

            _context.Add(post);
            _context.SaveChanges();
            return Ok(cad);
        }

        [HttpGet]
        public async Task<IActionResult> ListCommand()
        {
            try
            {
                var lista = await _context.Commands_Entity.
                Include(p => p.productDatails).
                Include(t => t.restaurantTable).Select(c => new
                {
                    c.Id,
                    c.Description,
                    restaurantTable = c.restaurantTable != null ? c.restaurantTable.Description : "",
                    
                    
                     productDetails = c.productDatails!.Select(pd => new
                {
                    pd.Id,
                    pd.Barcode,
                    pd.Description,
                    pd.Qtd,
                    pd.Sale_Price,
                    TotalPrice = pd.Qtd * pd.Sale_Price, // Multiplicação da quantidade pelo preço de venda
                    pd.date_Of_Sale,
                    pd.commandId
                }),
                    
                    
                    Total_Command = c.productDatails.Sum(pd => pd.Qtd * pd.Sale_Price)



                }).ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    
        [HttpGet("{id}")]
public async Task<IActionResult> JsonCommand(int id)
{
    try
    {
        var lista = await _context.Commands_Entity
            .Where(a => a.Id == id)
            .Include(p => p.productDatails)
            .Include(t => t.restaurantTable)
            .Select(c => new
            {
                c.Id,
                c.Description,
                restaurantTable = c.restaurantTable != null ? c.restaurantTable.Description : "",
                productDetails = c.productDatails.Select(pd => new
                {
                    pd.Id,
                    pd.Barcode,
                    pd.Description,
                    pd.Qtd,
                    pd.Sale_Price,
                    TotalPrice = pd.Qtd * pd.Sale_Price, // Multiplicação da quantidade pelo preço de venda
                    pd.date_Of_Sale,
                    pd.commandId
                }),
                Total_Command = c.productDatails.Sum(pd => pd.Qtd * pd.Sale_Price)
            })
            .ToListAsync();

        return Ok(lista);
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Internal server error: {ex.Message}");
    }
}

    
    
    
    
    }
}