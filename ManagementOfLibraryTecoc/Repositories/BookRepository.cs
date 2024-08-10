using ManagementOfLibraryTecoc.Models;


namespace ManagementOfLibraryTecoc.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public void RemoveBook(int bookid)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookid);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
        public void UpdateBook(Book book)
        {
            var ExistingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (ExistingBook != null)
            {
                ExistingBook.Title = book.Title;
                ExistingBook.Author = book.Author;
                ExistingBook.Gender = book.Gender;
                ExistingBook.State = book.State;
            }
        }
        public Book GetBook(int bookId)
        {
            return _books.FirstOrDefault(b => b.Id == bookId);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
    }
}
 