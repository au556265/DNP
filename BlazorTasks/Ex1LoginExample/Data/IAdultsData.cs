using System.Collections.Generic;
using Ex1LoginExample.Models;

namespace Ex1LoginExample.Data
{
    public interface IAdultsData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultID);
        void UpdateAdult(Adult adult);
        Adult Get(int id);


    }
}