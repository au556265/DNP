using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAssignment.Models;

namespace BlazorAssignment.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        Task RegisterUser(User user);
       
    }
}