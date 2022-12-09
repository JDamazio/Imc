using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_IMC.Models;

namespace ImcController
{
    [ApiController]
    [Route("api/imc")]
    public class ImcController : ControllerBase
    {
        private readonly DataContext _context;
        public ImcController(DataContext context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Imc imc)
        {
            imc.ImcCalc = (imc.Peso / (imc.Altura*imc.Altura));
            
            if(imc.ImcCalc < 18.5)
            {
                imc.classificacao = "MAGREZA";
            }
                
            else if(imc.ImcCalc < 24.9)
            {
                imc.classificacao = "NORMAL";
            }
                
            else if(imc.ImcCalc < 29.9)
            {
                imc.classificacao = "SOBREPESO";
            }
                
            else if(imc.ImcCalc < 39.9)
            {
                imc.classificacao = "OBESIDADE";
            }
                
            else
            {
                imc.classificacao = "OBESIDADE GRAVE";
            }
                
        
            _context.Imcs.Add(imc);
            _context.SaveChanges();
            return Created("", imc);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Imc> imcs =
                _context.Imcs.Include(f => f.Usuario).ToList();

            if (imcs.Count == 0) return NotFound();

            return Ok(imcs);
            
        }

        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Imc imc)
        {
            _context.Imcs.Update(imc);
            _context.SaveChanges();
            return Ok(imc);
        }
    }
}