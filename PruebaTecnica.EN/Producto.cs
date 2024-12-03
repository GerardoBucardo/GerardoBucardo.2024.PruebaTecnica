using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.EN
{
    public class Producto
    {
        public int Id { get; set; }
        public string? nombre { get; set; }
        public decimal? precio { get; set; }
        public int IdCategoria { get; set; }
        public Categoria? Categorias { get; set; }
    }
}
