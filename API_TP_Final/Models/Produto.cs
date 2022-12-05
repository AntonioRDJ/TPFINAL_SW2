using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_TP_Final.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float Preco { get; set; }
        public Boolean Status { get; set; }
        [ForeignKey("UsuarioCadastro")]
        public int IdUsuarioCadastro { get; set; }
        public Usuario UsuarioCadastro { get; set; }
        [ForeignKey("UsuarioUpdate")]
        public int? IdUsuarioUpdate { get; set; }
        public Usuario UsuarioUpdate { get; set; }
    }
}
