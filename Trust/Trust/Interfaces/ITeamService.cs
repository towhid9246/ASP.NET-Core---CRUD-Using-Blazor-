using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface ITeamService
    {
        Task<int> Create(Team team);
        Task<Team> ReadByPk(int TeamId);
        Task<int> Update(Team team);
        Task<int> Delete(int TeamId);
        Task<int> Count(string search);
        //Task<Team> GetById(int TeamId);
        //Task<List<Team>> FetchAll();
        Task<List<Team>> FetchAll();
        Task<List<Team>> ListAll(int skip,
                                   int take,
                                   string orderBy,
                                   string direction,
                                   string search);
    }
}
