using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class ProjectsDetailsService : IProjectsDetailsService
    {
        private readonly IDapperService _dapperService;
        public ProjectsDetailsService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(ProjectsDetails projectsDetails)
        {
            var dbPara = new DynamicParameters();
          
            dbPara.Add("Comments", projectsDetails.Comments, DbType.String);

            dbPara.Add("ProjectDate", projectsDetails.ProjectDate, DbType.Date);
            dbPara.Add("StaId", projectsDetails.StaId);
            //dbPara.Add("StaId", projectsDetails.StaId, DbType.Int32);
            var projectsDetailsId = Task.FromResult(_dapperService.
                Insert<int>("[dbo].[spAddProjectsDetails]", dbPara,
                commandType: CommandType.StoredProcedure));

            return projectsDetailsId;
        }
        public Task<ProjectsDetails> GetById(int DetailsId)
        {

            var projectsDetails = Task.FromResult(_dapperService.Get<ProjectsDetails>
                ($"select * from [ProjectsDetails] where DetailsId = {DetailsId}",
                null, commandType: CommandType.Text));
            return projectsDetails;
        }
        public Task<int> Update(ProjectsDetails projectsDetails)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DetailsId", projectsDetails.DetailsId);
            dbPara.Add("Comments", projectsDetails.Comments, DbType.String);

            dbPara.Add("ProjectDate", projectsDetails.ProjectDate, DbType.Date);
            dbPara.Add("StaId", projectsDetails.StaId);
            //dbPara.Add("StaId", projectsDetails.StaId, DbType.Int32);

            var updateProjectsDetails = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateProjectsDetails]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateProjectsDetails;
        }
        public Task<int> Delete(int DetailsId)
        {
            var deleteProjectsDetails = Task.FromResult(_dapperService.Execute
                ($"Delete [ProjectsDetails] where DetailsId = {DetailsId}", null,
                commandType: CommandType.Text));
            return deleteProjectsDetails;
        }
        public Task<int> Count(string search)
        {
            var totProjectsDetails = Task.FromResult(_dapperService.Get<int>
               ($"select COUNT(*) from [ProjectsDetails] " +
               $"WHERE StaId like '%{search}%'", null,
               commandType: CommandType.Text));
            return totProjectsDetails;
        }


        public Task<List<ProjectsDetailsSta>> ListAll(int skip,
             int take, string orderBy, string direction = "DESC",
             string search = "")
        {
            var projectsDetailss = Task.FromResult(_dapperService.
            GetAll<ProjectsDetailsSta>($"SELECT p.*, s.StatusName StaName FROM ProjectsDetails p LEFT OUTER JOIN Status s ON p.StaId = p.StaId WHERE StaId like '%{search}%'ORDER BY { orderBy} { direction} OFFSET { skip} ROWS FETCH NEXT { take} ROWS ONLY; ", null,













                commandType: CommandType.Text));
            return projectsDetailss;
        }


    }
}