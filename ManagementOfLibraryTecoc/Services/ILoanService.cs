using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Services
{
    public interface ILoanService
    {
        void AddLoan(Loan loan);
        void AddDevolution(int LoanId);
        IEnumerable<Loan> GetLoanExpirate();
        IEnumerable<Loan> GetAllLoans();
    }
}
