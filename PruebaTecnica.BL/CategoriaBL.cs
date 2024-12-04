using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.DAL;
using PruebaTecnica.EN;

namespace PruebaTecnica.BL
{
    public class CategoriaBL
    {
        public static async Task<Categoria> GetById(int id)
        {
            return await CategoriaDAL.GetById(id);
        }
        public static async Task<int> Create(Categoria pRole)
        {
            return await CategoriaDAL.Create(pRole);
        }
        public static async Task<int> Update(Categoria pRole)
        {
            return await CategoriaDAL.Update(pRole);
        }
        public static async Task<int> Delete(Categoria pRole)
        {
            return await CategoriaDAL.Delete(pRole);
        }
        public static async Task<List<Categoria>> GetAll()
        {
            return await CategoriaDAL.GetAll();
        }
    }
}
