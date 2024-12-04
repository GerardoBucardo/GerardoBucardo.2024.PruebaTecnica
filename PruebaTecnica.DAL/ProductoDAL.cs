using Microsoft.EntityFrameworkCore;
using PruebaTecnica.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DAL
{
    public class ProductoDAL
    {
        public static async Task<Producto> GetById(int id)
        {
            var producto = new Producto();
            using (var dbContext = new ComunDB())
            {
                producto = await dbContext.Productos.Include(r => r.Categorias).FirstOrDefaultAsync(s => s.Id == id);
            }

            return producto;
        }
        public static async Task<int> Create(Producto pProducto)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(pProducto);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Update(Producto pProducto)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var producto = await bdContext.Productos.FirstOrDefaultAsync(r => r.Id == pProducto.Id);
                producto.nombre = pProducto.nombre;
                producto.precio = pProducto.precio;
                producto.IdCategoria = pProducto.IdCategoria;
                bdContext.Update(producto);
                result = await bdContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Delete(Producto pProducto)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var producto = await bdContext.Productos.FirstOrDefaultAsync(r => r.Id == pProducto.Id);
                bdContext.Remove(producto);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<Producto>> GetAll()
        {
            var producto = new List<Producto>();
            using (var bdContext = new ComunDB())
            {
                producto = await bdContext.Productos.ToListAsync();
            }
            return producto;
        }
    }
}
