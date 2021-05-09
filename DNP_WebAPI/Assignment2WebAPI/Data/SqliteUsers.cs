using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Models;
using Assignment2WebAPI.Persistence;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment2WebAPI.Data
{
    public class SqliteUsers : IUserService
    {
        /*private DataContext dataContext;


        public SqliteUsers(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }*/
        public async Task<User> ValidateUser(string userName, string password)
        {
            await using DataContext dataContext = new DataContext();

            User first = dataContext.Userss.FirstOrDefault(user =>
                user.UserName.Equals(userName) && user.Password.Equals(password));
            if (first == null) {
                throw new Exception("User not found");
            }
            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }
            return first;
        }

        public async Task<User> RegisterUser(User user)
        {
            await using DataContext dataContext = new DataContext();

            EntityEntry<User> newlyAdded = await dataContext.Userss.AddAsync(user);
            await dataContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }
    }
}