using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.EN;
using PruebaTecnica.DAL;

namespace PruebaTecnica.BL
{
    public class ProductoBL
    {
        public static async Task<Producto> GetById(int id)
        {
            return await ProductoDAL.GetById(id);
        }
        public static async Task<int> Create(Producto pProducto)
        {
            return await ProductoDAL.Create(pProducto);
        }
        public static async Task<int> Update(Producto pProducto)
        {
            return await ProductoDAL.Update(pProducto);
        }
        public static async Task<int> Delete(Producto pProducto)
        {
            return await ProductoDAL.Delete(pProducto);
        }
        public static async Task<List<Producto>> GetAll()
        {
            return await ProductoDAL.GetAll();
        }
    }
}
