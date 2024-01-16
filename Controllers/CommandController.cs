using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
            try
            {
                var post = new Command
                {
                    Description = create.Description
                };


                var result = new
                {
                    Card = post,
                    Menssage = "Todos os Cards"
                };

                _context.Add(post);
                _context.SaveChanges();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao criar comando: {ex.Message}");
            }
        }
        [HttpGet("/SearchItem/{seach}")]
        public IActionResult GetCommands(string seach)
        {
            try
            {
                var lista = _context.Commands_Entity
                    .Include(pd => pd.productDetails)
                    .Where(s => s.Description.Contains(seach)|| s.Id.ToString().Contains(seach))
                    .ToList();

                var result = new
                {
                    result = lista
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao buscar comandos: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCommand(int id, [FromBody] CommandDTO_Update update)
        {
            try
            {
                var existingCommand = _context.Commands_Entity.Find(id);

                if (existingCommand == null)

                {
                    var msg = new
                    {
                        menssage = "Comando não encontrado"
                    };
                    return NotFound(msg);
                }


                existingCommand.Description = update.Description;

                _context.Update(existingCommand);
                _context.SaveChanges();

                var result = new
                {

                    Command = existingCommand,

                    Message = "Comando atualizado com sucesso"
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao atualizar comando: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCommand(int id)
        {
            try
            {
                var existingCommand = _context.Commands_Entity.Find(id);

                if (existingCommand == null)
                {
                    return NotFound("Comando não encontrado");
                }

                _context.Commands_Entity.Remove(existingCommand);
                _context.SaveChanges();

                var result = new
                {
                    Message = "Comando excluído com sucesso"
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao excluir comando: {ex.Message}");
            }
        }



    }
}