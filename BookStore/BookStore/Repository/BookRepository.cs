using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel>  GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookByID(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title , string authorName)
        {
            return DataSource().Where(x => x.Title == title || x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "Naruto", Author = "kakashi" },
                new BookModel() { Id = 2, Title = "Marvel", Author = "sid" },
                new BookModel() { Id = 3, Title = "Attack On Titen", Author = "darshan" },
                new BookModel() { Id = 4, Title = "Game Of Thrones", Author = "vedant" },
                new BookModel() { Id = 5, Title = "DC", Author = "het" }
            };
        }
    }
}
