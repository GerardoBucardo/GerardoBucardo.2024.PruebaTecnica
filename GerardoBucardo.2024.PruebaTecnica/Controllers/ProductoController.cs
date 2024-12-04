using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.BL;
using PruebaTecnica.EN;

namespace GerardoBucardo._2024.PruebaTecnica.Controllers
{
    public class ProductoController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var producto = await ProductoBL.GetAll();
            return View(producto);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var producto = await ProductoBL.GetById(id);
            return View(producto);
        }

        // GET: UserController/Create
        public async Task<ActionResult> Create()
        {
            var productos = await ProductoBL.GetAll();
            ViewBag.Productos = productos;
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Producto pProducto)
        {
            try
            {
                var result = await ProductoBL.Create(pProducto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var producto = await ProductoBL.GetById(id);
            var categorias = await CategoriaBL.GetAll();
            ViewBag.Categorias = categorias;
            return View(producto);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Producto pProducto)
        {
            try
            {
                var result = await ProductoBL.Update(pProducto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var producto = await ProductoBL.GetById(id);
            return View(producto);

        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Producto pProducto)
        {
            try
            {
                var result = await ProductoBL.Delete(pProducto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
