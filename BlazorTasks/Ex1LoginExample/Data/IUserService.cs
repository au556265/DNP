using System.Collections.Generic;
using System.Threading.Tasks;
using Ex1LoginExample.Models;

namespace Ex1LoginExample.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        Task RegisterUser(User user);
       
    }
}