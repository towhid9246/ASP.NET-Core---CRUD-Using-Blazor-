using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface IProjectStatusService
    {
        Task<int> Create(ProjectStatusName projectStatusNamer);
        Task<int> Delete(int isbn, int statusId);
        Task<List<ProjectStatusName>> FetchAll(int isbn);
    }
}