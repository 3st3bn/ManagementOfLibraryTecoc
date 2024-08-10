using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly List<Loan> _loans = new List<Loan>();
        public void AddLoan(Loan loan)
        {
            _loans.Add(loan);
        }
        public void UpdateLoan(Loan loan)
        {
            var ExistingLoan = _loans.FirstOrDefault(l => l.Id == loan.Id);
            if (ExistingLoan != null)
            {
                ExistingLoan.BookId = loan.BookId;
                ExistingLoan.UserId = loan.UserId;
                ExistingLoan.LoanDate = loan.LoanDate;
                ExistingLoan.ExpirationDate = loan.ExpirationDate;
                ExistingLoan.Returned = loan.Returned;
            }
        }
        public Loan GetLoan(int LoanId)
        {
            return _loans.FirstOrDefault(l => l.Id == LoanId);
        }
        public IEnumerable<Loan> GetAllLoans()
        {
            return _loans;
        }
        public IEnumerable<Loan> GetLoanExpirate()
        {
            return _loans.Where(l => l.ExpirationDate < DateTime.Now && !l.Returned);
        }
    }
}
