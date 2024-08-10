using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void RemoveBook(int bookId);
        void UpdateBook(Book book);
        Book GetBook(int bookId);

        IEnumerable<Book> GetAllBooks();
    }
}
