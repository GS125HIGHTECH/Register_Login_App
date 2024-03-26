using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();

        public SecurityService()
        {
            
        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserNameAndPassword(user);
        }
    }
}
