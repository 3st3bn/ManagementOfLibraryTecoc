using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Repositories
{
    public interface ILoanRepository
    {
        void AddLoan(Loan loan);
        void UpdateLoan(Loan loan);
        Loan GetLoan(int LoanId);
        IEnumerable<Loan> GetLoanExpirate();
        IEnumerable<Loan> GetAllLoans();
    }
}
