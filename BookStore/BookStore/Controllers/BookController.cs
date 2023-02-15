using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using BookStore.Data;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {

        //private readonly BookRepository _bookRepository = null;
        private readonly ApplicationDbContext _db;


        //public BookController()
        //{
        //    _bookRepository = new BookRepository();
        //}

        public BookController(ApplicationDbContext db)
        {
             _db = db;
        }

        public IActionResult GetAllBooks()
        {
            IEnumerable<BookModel> obj = _db.bookModels;
            return View(obj);
        }


        public IActionResult AddBook()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookModel obj)
        {
            _db.bookModels.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("GetAllBooks");
        }


        public IActionResult EditBook(int? id)
        {
            var book = _db.bookModels.Find(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(BookModel obj)
        {
            _db.bookModels.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("GetAllBooks");
        }


        public IActionResult DeleteBook(int? id)
        {
            var book = _db.bookModels.Find(id);

            return RedirectToAction("GetAllBooks");
        }

        [HttpPost]
        public IActionResult DeleteBook(BookModel obj)
        {
            _db.bookModels.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("GetAllBooks");
        }
    }
}
