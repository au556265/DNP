using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Assignment2WebAPI.Models;
using Assignment2WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment2WebAPI.Data
{
    public class SqliteAdults : IAdultsData
    {
       // private DataContext ctx;

       /* public SqliteAdults(DataContext ctx)
        {
            this.ctx = ctx;
        }*/

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            await using DataContext dataContext = new DataContext();
            return await dataContext.Adultss.Include(adult => adult.JobPosition).ToListAsync();
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            await using DataContext dataContext = new DataContext();
            EntityEntry<Adult> newlyAdded = await dataContext.Adultss.AddAsync(adult);
            await dataContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        public async Task RemoveAdultAsync(int adultID)
        {
            await using DataContext dataContext = new DataContext();

            Adult toDelete = await dataContext.Adultss.FirstOrDefaultAsync(t => t.Id == adultID);
            if (toDelete != null)
            {
                dataContext.Adultss.Remove(toDelete);
                await dataContext.SaveChangesAsync();
            }
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult)
        {
            await using DataContext dataContext = new DataContext();

            try
            {
                Adult toUpdate = await dataContext.Adultss.Include(adult => adult.JobPosition).FirstAsync(t => t.Id == adult.Id); 
                Console.WriteLine("testing " + toUpdate );

                toUpdate.JobPosition.JobTitle = adult.JobPosition.JobTitle;
               toUpdate.JobPosition.Salary = adult.JobPosition.Salary;
               toUpdate.FirstName = adult.FirstName;
               toUpdate.LastName = adult.LastName;
               toUpdate.HairColor = adult.HairColor;
               toUpdate.Weight = adult.Weight;
               toUpdate.Height = adult.Height;
               
              dataContext.Update(toUpdate);
               await dataContext.SaveChangesAsync(); 
               return toUpdate;
               
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find todo with id{adult.Id}");
            }
            
        }

        public async Task<Adult> Get(int id)
        {
            await using DataContext dataContext = new DataContext();
            return await dataContext.Adultss.Include(adult => adult.JobPosition).
                FirstAsync(adult => adult.Id == id );
        }
    }
}