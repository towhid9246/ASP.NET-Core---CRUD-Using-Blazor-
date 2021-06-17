using Trust.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Trust.Interfaces
{
    public interface IProjectsDetailsService
    {
        Task<int> Create(ProjectsDetails projectsDetails);
        Task<int> Delete(int DetailsId);
        Task<int> Count(string search);
        Task<int> Update(ProjectsDetails ProjectsDetails);
        Task<ProjectsDetails> GetById(int DetailsId);
        Task<List<ProjectsDetailsSta>> ListAll(int skip, int take,
            string orderBy, string direction, string search);
    }
}