using Microsoft.AspNetCore.Mvc;

using BookStore.Models;
using BookStore.Repository;
using BookStore.Data;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;


        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult AllCategories()
        {
            IEnumerable<Category> obj = _db.categories;
            return View(obj);
        }

        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("AllCategories");
            }
            return View(obj);
            
        }


        public IActionResult EditCategory(int? id)
        {
            var book = _db.categories.Find(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult EditCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.categories.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("AllCategories");
            }
            return View(obj);

        }
    
        public IActionResult Delete(int? id)
        {
            var book = _db.categories.Find(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int? id)
        {
            var book = _db.categories.Find(id);
            _db.categories.Remove(book);
            _db.SaveChanges();
            return RedirectToAction("AllCategories");
            //return View("AllCategories");

        }
    }
}
