using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface ITeamAssignService
    {
        Task<int> Create(TeamAssign teamAssign);
        Task<TeamAssign> GetById(int AssignId);
        Task<int> Update(TeamAssign teamAssign);
        Task<int> Delete(int AssignId);
        Task<int> Count(string search);
        //Task<Team> GetById(int TeamId);
        //Task<List<Team>> FetchAll();
        //Task<List<TeamAssign>> FetchAll();
        Task<List<TeamAssignUs>> ListAll(int skip,
                                   int take,
                                   string orderBy,
                                   string direction,
                                   string search);
    }
}
