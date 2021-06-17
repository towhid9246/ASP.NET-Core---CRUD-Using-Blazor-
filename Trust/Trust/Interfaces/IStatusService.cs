using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface IStatusService
    {
        Task<int> Create(Status status);
        Task<Status> GetById(int StatusId);
        Task<int> Update(Status status);
        Task<int> Delete(int StatusId);
        Task<int> Count(string search);
        Task<List<Status>> FetchAll();
        Task<List<Status>> ListAll(int skip,
                                   int take,
                                   string orderBy,
                                   string direction,
                                   string search);
    }
}
