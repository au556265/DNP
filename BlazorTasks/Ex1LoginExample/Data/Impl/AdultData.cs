using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Ex1LoginExample.Models;
using Ex1LoginExample.Persistence;

namespace Ex1LoginExample.Data.Impl
{
    public class AdultData : IAdultsData
    {
        private FileContext fileContext;

        
        public AdultData(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }
        
        
        public IList<Adult> GetAdults()
        {
            return fileContext.Adults;
            
        }

        public void AddAdult(Adult adult)
        {
            int max;
            fileContext.Adults.Add(adult);
            max = fileContext.Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            fileContext.SaveChanges();
            
        }

        public void RemoveAdult(int adultID)
        {
            Adult toRemove = fileContext.Adults.First(t=>t.Id==adultID);
            fileContext.Adults.Remove(toRemove);
            fileContext.SaveChanges();
        }

        public void UpdateAdult(Adult adult)
        {
            Adult toUpdate = fileContext.Adults.First(a => a.Id == adult.Id);
            toUpdate.JobPosition = adult.JobPosition;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            fileContext.SaveChanges();
        }

        public Adult Get(int id)
        {
            return fileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}