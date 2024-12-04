using Microsoft.EntityFrameworkCore;
using PruebaTecnica.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.DAL
{
    public class CategoriaDAL
    {
        public static async Task<Categoria> GetById(int id)
        {
            var categoria = new Categoria();
            using (var dbContext = new ComunDB())
            {
                categoria = await dbContext.Categorias.FirstOrDefaultAsync(s => s.Id == id);
            }

            return categoria;
        }

        public static async Task<int> Create(Categoria pCategoria)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                dbContext.Add(pCategoria);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Update(Categoria pCategoria)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var categoria = await bdContext.Categorias.FirstOrDefaultAsync(r => r.Id == pCategoria.Id);
                categoria.nombre = pCategoria.nombre;
                bdContext.Update(categoria);
                result = await bdContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Delete(Categoria pCategoria)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var categoria = await bdContext.Categorias.FirstOrDefaultAsync(r => r.Id == pCategoria.Id);
                bdContext.Remove(categoria);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<Categoria>> GetAll()
        {
            var categoria = new List<Categoria>();
            using (var bdContext = new ComunDB())
            {
                categoria = await bdContext.Categorias.ToListAsync();
            }
            return categoria;
        }
    }
}
