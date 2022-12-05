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
    public class ProdutosController : Controller
    {
        private readonly TPContext _context;

        public ProdutosController(TPContext context)
        {
            _context = context;
        }
        // GET: api/v1/produtos
        [HttpGet]
        public String Index()
        {
            var produtos = _context.Produtos.Select(p => new Produto
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,              
                Status = p.Status,
                UsuarioCadastro = p.UsuarioCadastro,
                UsuarioUpdate = p.UsuarioUpdate
            });
            return JsonConvert.SerializeObject(produtos);
        }

        // GET: api/v1/produtos/5
        [HttpGet("{id}")]
        public async Task<String> Details(int id)
        {
            var produto = await _context.Produtos.Include(usuario => usuario.UsuarioCadastro).Include(usuario => usuario.UsuarioUpdate).FirstOrDefaultAsync(m => m.Id == id);
            return JsonConvert.SerializeObject(produto);
        }

        // POST: api/v1/produtos
        [HttpPost]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return Ok(produto);
            }
            return NotFound();
        }

        // PUT: api/v1/produtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Produto produto)
        {

            if (ModelState.IsValid)
            {
                var produtoAntigo = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);

                produtoAntigo.Nome = produto.Nome;
                produtoAntigo.Preco = produto.Preco;
                produtoAntigo.Status = produto.Status;
                produtoAntigo.UsuarioCadastro = produto.UsuarioCadastro;
                produtoAntigo.UsuarioUpdate = produto.UsuarioUpdate;
    
                await _context.SaveChangesAsync();
                return Ok(produtoAntigo);
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/v1/produtos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            if (entity == null)
                return NotFound();
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
