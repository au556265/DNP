using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAssignment.Models;

namespace BlazorAssignment.Data
{
    public interface IAdultsData
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultID);
        Task UpdateAdultAsync(Adult adult);
        Task <Adult> Get(int id);

    }
}