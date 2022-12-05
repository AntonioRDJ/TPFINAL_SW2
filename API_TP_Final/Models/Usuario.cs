using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_TP_Final.Models
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Boolean Status { get; set; }
    }
}
