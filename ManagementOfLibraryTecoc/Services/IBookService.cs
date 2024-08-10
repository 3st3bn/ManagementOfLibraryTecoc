using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Services
{
    public interface IBookService
    {
        void AddBook(Book book);
        void RemoveBook(int bookId);
        void UpdateBook(Book book);
         Book GetBook(int bookId);

        IEnumerable<Book> GetAllBooks();
    }
}
