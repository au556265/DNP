using System;
using System.Linq;
using Ex1LoginExample.Models;
using Ex1LoginExample.Persistence;

namespace Ex1LoginExample.Data.Impl
{
    public class InMemoryUserService: IUserService {

        private FileContext fileContext;
        
        public InMemoryUserService(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }
        
        public User ValidateUser(string userName, string password) {
            User first = fileContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public void RegisterUser(User user)
        {
            fileContext.Users.Add(user);
            fileContext.SaveChanges();
        }
    }
}