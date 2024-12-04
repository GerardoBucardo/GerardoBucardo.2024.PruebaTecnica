using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.BL;
using PruebaTecnica.EN;
using System.Data;

namespace GerardoBucardo._2024.PruebaTecnica.Controllers
{
    public class CategoriaController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var categoria = await CategoriaBL.GetAll();
            return View(categoria);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var categoria = await CategoriaBL.GetById(id);
            return View(categoria);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Categoria pCategoria)
        {
            try
            {
                var result = await CategoriaBL.Create(pCategoria);
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
            var categoria = await CategoriaBL.GetById(id);
            return View(categoria);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Categoria pCategoria)
        {
            try
            {
                var result = await CategoriaBL.Update(pCategoria);
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
            var categoria = await CategoriaBL.GetById(id);
            return View(categoria);

        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Categoria pCategoria)
        {
            try
            {
                var result = await CategoriaBL.Delete(pCategoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
