using Microsoft.EntityFrameworkCore;
using API_TP_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TP_Final
{
    public class TPContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public TPContext() { }

        public TPContext(DbContextOptions<TPContext> options) : base(options) { }
    }
}
