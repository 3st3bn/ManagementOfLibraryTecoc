using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Repositories
{
    public interface IUserRepositoty
    {
        void AddUser(User user);
        void UpdateUser(User user);
        User  GetUser(int UserId);
        IEnumerable<User> GetAllUsers();

    } 
}
