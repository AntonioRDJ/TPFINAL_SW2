using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using API_TP_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TP_Final.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsuariosController : Controller
    {

        private readonly TPContext _context;

        public UsuariosController(TPContext context)
        {
            _context = context;
        }

        // GET: api/v1/usuarios
        [HttpGet]
        public String Index()
        {
            var usuarios = _context.Usuarios.Select(u => new Usuario
            {
                Id = u.Id,
                Nome = u.Nome,
                Senha = u.Senha,
                Status = u.Status
            });
            return JsonConvert.SerializeObject(usuarios);
        }

        // GET: api/v1/usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Details(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.Id == id);
            return Json(usuario);
        }

        // POST: api/v1/usuarios/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Nome) && !string.IsNullOrEmpty(usuario.Senha))
            {
                var usuarioBd = await _context.Usuarios.FirstOrDefaultAsync(m => m.Nome == usuario.Nome && m.Senha == usuario.Senha);
                if(usuarioBd != null)
                {
                    return Json(usuarioBd);
                }
            }
            
            return Unauthorized();
        }

        // POST: api/v1/usuarios
        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        // PUT: api/v1/usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                var usuarioAntigo = await _context.Usuarios.FirstOrDefaultAsync(m => m.Id == id);

                usuarioAntigo.Nome = usuario.Nome;
                usuarioAntigo.Senha = usuario.Senha;
                usuarioAntigo.Status = usuario.Status;       

                await _context.SaveChangesAsync();
                return Ok(usuarioAntigo);
            }
            else
            {
                return NotFound();
            }
    
        }

        // DELETE: api/v1/usuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _context.Usuarios.FirstOrDefaultAsync(m => m.Id == id);
            if (entity == null)
                return NotFound();
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return Ok();
        }

       
        
    }
}
