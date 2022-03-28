using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPCE.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
    }
}
