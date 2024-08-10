using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Services;

namespace ManagementOfLibraryTecoc.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public void AddUser(User user)
        {
            _userService.RegisterUser(user);
        }
        public void UpdateUser(User user)
        {
            _userService.UpdateUser(user);
        }
        public User GetUser(int UserId)
        {
            return _userService.GetUser(UserId);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        public IEnumerable<Loan> GetRecordLoans()
        {
            return _userService.GetRecordLoans();
        }
    }
}
