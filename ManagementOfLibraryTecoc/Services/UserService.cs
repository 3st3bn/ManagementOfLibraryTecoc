using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Repositories;

namespace ManagementOfLibraryTecoc.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositoty  _userRepository;
        private readonly ILoanRepository  _loanRepository; 

        public UserService(IUserRepositoty userRepository, ILoanRepository loanRepository)
        {
            _userRepository = userRepository;
            _loanRepository = loanRepository;
        }
        public void RegisterUser(User user)
        {
            _userRepository.AddUser(user);
        }
        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public IEnumerable<Loan> GetRecordLoans()
        {
            return _loanRepository.GetAllLoans();
        }

    }
}
