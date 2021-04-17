using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Models;
using Assignment2WebAPI.Persistence;

namespace Assignment2WebAPI.Data
{
    public class AdultData: IAdultsData
    {
        private FileContext fileContext;

        public AdultData(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }
        
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return fileContext.Adults;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max;
            fileContext.Adults.Add(adult);
            max = fileContext.Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            fileContext.SaveChanges();
            return adult;
        }

        public async Task RemoveAdultAsync(int adultID)
        {
            Adult toRemove = fileContext.Adults.First(t=>t.Id==adultID);
            fileContext.Adults.Remove(toRemove);
            fileContext.SaveChanges();
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult)
        {
            Adult toUpdate = fileContext.Adults.First(a => a.Id == adult.Id);
            toUpdate.JobPosition = adult.JobPosition;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            fileContext.SaveChanges();
            return adult;
        }

        public async Task<Adult> Get(int id)
        {
            return fileContext.Adults.FirstOrDefault(a => a.Id == id);

        }
    }
}
