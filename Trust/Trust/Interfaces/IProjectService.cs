using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface IProjectService
    {
        Task<int> Create(Project project);
        //Task<Project> ReadByPk(long isbn);
        Task<int> Update(Project project, int pk);
        Task<int> Delete(int ProjectId);
        Task<int> Count(string search);
        Task<List<Project>> FetchAll();
        Task<Project> GetById(int ProjectId);
        Task<List<ProjectStTea>> ListAll(int skip,
                                   int take,
                                   string orderBy,
                                   string direction,
                                   string search);
    }
}
