using ManagementOfLibraryTecoc.Models;

namespace ManagementOfLibraryTecoc.Repositories
{
    public class UserRepository : IUserRepositoty
    {
        private readonly List<User> _users = new List<User>();
        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public void UpdateUser(User user)
        {
            var ExistingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (ExistingUser != null)
            {
                {
                    ExistingUser.Name = user.Name;
                    ExistingUser.IdentificationNumber = user.IdentificationNumber;
                    ExistingUser.Addres = user.Addres;
                }
            }
        }
        public User GetUser(int UserId)
        {
            return _users.FirstOrDefault(u => u.Id == UserId);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }
    }
}
