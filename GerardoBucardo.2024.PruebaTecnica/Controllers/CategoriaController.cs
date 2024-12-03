using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.BL;
using System.Data;

namespace GerardoBucardo._2024.PruebaTecnica.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Index()
        {
            var role = await CategoriaBL.GetAll();
            return View(role);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var role = await RoleBL.GetById(id);
            return View(role);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Role pRole)
        {
            try
            {
                var result = await RoleBL.Create(pRole);
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
            var role = await RoleBL.GetById(id);
            return View(role);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Role pRole)
        {
            try
            {
                var result = await RoleBL.Update(pRole);
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
            var role = await RoleBL.GetById(id);
            return View(role);

        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Role pRole)
        {
            try
            {
                var result = await RoleBL.Delete(pRole);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
