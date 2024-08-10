using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Repositories;

namespace ManagementOfLibraryTecoc.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _BookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _BookRepository = bookRepository;
        }
        public void AddBook(Book book)
        {
            _BookRepository.AddBook(book);
        }
        public void RemoveBook(int bookId)
        {
            _BookRepository.RemoveBook(bookId);
        }
        public void UpdateBook(Book book)
        {
           _BookRepository.UpdateBook(book);
        }
        public Book GetBook(int bookId)
        {
           return  _BookRepository.GetBook(bookId);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _BookRepository.GetAllBooks();
        }
    }
}
