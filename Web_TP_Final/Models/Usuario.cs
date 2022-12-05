using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_TP_Final.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Boolean Status { get; set; }
    }
}
