using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Services
{
    public interface IUserService
    {
        void RegisterUser(User user);
        void UpdateUser(User user);
        User  GetUser(int UserId);
        IEnumerable<User> GetAllUsers();
        IEnumerable<Loan> GetRecordLoans();

    }
}
