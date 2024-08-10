using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Services;

namespace ManagementOfLibraryTecoc.Controllers
{
    public class LoanController
    {
        private readonly ILoanService _loanService;
        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }
        public void AddLoan(Loan loan)
        {
            _loanService.AddLoan(loan);
        }
        public void RegisterReturn(int prestamoId)
        {
            _loanService.AddDevolution(prestamoId);
        }
        public IEnumerable<Loan> GetLoanExpirate()
        {
            return _loanService.GetLoanExpirate();
        }
        public IEnumerable<Loan> GGetAllLoans()
        {
            return _loanService.GetAllLoans();
        }
    }
}
