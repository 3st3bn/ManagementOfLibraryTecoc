using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Services;
using System.Runtime.CompilerServices;

namespace ManagementOfLibraryTecoc.Controllers
{
    public class BookController
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public void AddBook(Book book)
        {
            _bookService.AddBook(book);
        }
        public void RemoveBook(int  bookId)
        {
            _bookService.RemoveBook(bookId);
        }
        public void UpdateBook(Book book)
        {
            _bookService.UpdateBook(book);
        }
        public Book GetBook(int bookId)
        {
            return _bookService.GetBook(bookId);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
    }
}
