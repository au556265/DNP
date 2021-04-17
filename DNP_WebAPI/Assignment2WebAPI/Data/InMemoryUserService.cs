using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Models;
using Assignment2WebAPI.Persistence;


namespace Assignment2WebAPI.Data
{
    public class InMemoryUserService: IUserService {

        private FileContext fileContext;
        
        public InMemoryUserService(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }
        
        public async Task<User> ValidateUser(string userName, string passWord) {
            User first =  fileContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(passWord)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
        public async Task<User> RegisterUser(User user)
        {
            Console.WriteLine(" user " + user.UserName);
            if (string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.Password) || string.IsNullOrWhiteSpace(user.Role))
            {
                throw new Exception("Fields should not be empty");
            }
            else if (fileContext.Users.FirstOrDefault(u => user.UserName==u.UserName) !=null)
            {
                throw new Exception("Username already exists");
            }

            fileContext.Users.Add(user);
            fileContext.SaveChanges();
            return user;
        }
        
    }
}