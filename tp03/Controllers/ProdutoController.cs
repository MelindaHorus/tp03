using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp03.Models;
using System.Linq;

namespace tp03.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoContext db = new();

        // GET: ProdutoController
        public ActionResult Index()
        {
            var produtos = db.Produtos.ToList();
            return View(produtos);
        }

        // GET: ProdutoController/Details/5
        public ActionResult Details(int id)
        {
            var produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: ProdutoController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = db.Produtos.Find(id);
            if (produto != null)
            {
                db.Produtos.Remove(produto);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
