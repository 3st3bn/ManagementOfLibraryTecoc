using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Repositories;

namespace ManagementOfLibraryTecoc.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        public LoanService(ILoanRepository loanRepository, IBookRepository bookRepository )
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
        }
        public void AddLoan(Loan loan)
        {
            loan.LoanDate = DateTime.Now;
            loan.ExpirationDate = DateTime.Now.AddDays(14);
            _loanRepository.AddLoan(loan);
            var book = _bookRepository.GetBook(loan.BookId);
            book.State = "Prestado";
            _bookRepository.UpdateBook(book);
        }
        public void AddDevolution(int loanId)
        {
            var loan  = _loanRepository.GetLoan(loanId);
            loan.Returned = true;
            _loanRepository.UpdateLoan(loan);
            var book = _bookRepository.GetBook(loan.BookId);
            book.State = "Disponible";
            _bookRepository.UpdateBook(book);   
        }
        public IEnumerable<Loan> GetLoanExpirate()
        {
            return _loanRepository.GetAllLoans()
                .Where(p => p.ExpirationDate <  DateTime.Now && !p.Returned);
        }
        public IEnumerable<Loan> GetAllLoans()
        {
            return _loanRepository.GetAllLoans();
        }
    }
}
