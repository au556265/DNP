
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment2WebAPI.Models;

namespace Assignment2WebAPI.Data
{
    public interface IUserService
    {
        Task <User> ValidateUser(string userName, string password);
        Task <User> RegisterUser(User user);
    }
}