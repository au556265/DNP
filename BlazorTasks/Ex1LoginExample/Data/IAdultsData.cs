﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ex1LoginExample.Models;

namespace Ex1LoginExample.Data
{
    public interface IAdultsData
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultID);
        Task<Adult> UpdateAdultAsync(Adult adult);
        Task <Adult> Get(int id);

    }
}