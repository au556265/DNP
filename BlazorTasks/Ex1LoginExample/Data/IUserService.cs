using Ex1LoginExample.Models;

namespace Ex1LoginExample.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        void RegisterUser(User user);
    }
}