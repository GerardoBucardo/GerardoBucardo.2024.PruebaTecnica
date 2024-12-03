using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaTecnica.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DAL
{
    public class ComunDB : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public ComunDB(DbContextOptions<ComunDB> options ):base(options) { }
    }
}
