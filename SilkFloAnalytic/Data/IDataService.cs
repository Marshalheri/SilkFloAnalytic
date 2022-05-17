using SilkFloAnalytic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SilkFloAnalytic.Data
{
    public interface IDataService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<Complaint>> GetComplaints();
    }
}
