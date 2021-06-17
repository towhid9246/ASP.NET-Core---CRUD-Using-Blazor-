using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class ProjectStatusService : IProjectStatusService
    {
        private readonly IDapperService _dapperService;
        public ProjectStatusService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(ProjectStatusName projectStatusName)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ProjectId", projectStatusName.ProjectId, DbType.Int64);
            dbPara.Add("StatusId", projectStatusName.StatusId, DbType.Int32);


            var projectStatusId = Task.FromResult(_dapperService.
                Insert<int>("[dbo].[spAddProjectStatus]", dbPara,
                commandType: CommandType.StoredProcedure));
            return projectStatusId;
        }
        public Task<int> Delete(int isbn, int StatusId)
        {
            var deleteProjectStatus = Task.FromResult(_dapperService.
                Execute($"Delete [ProjectStatus] where ProjectId = {isbn} " +
                $"and StatusId = {StatusId}", null,
                commandType: CommandType.Text));
            return deleteProjectStatus;
        }
        public Task<List<ProjectStatusName>> FetchAll(int isbn)
        {
            var projectStatusNames = Task.FromResult(_dapperService.GetAll
                <ProjectStatusName>($"select * from ProjectStatusName " +
                $"({isbn}) order by StatusName; ", null,
                commandType: CommandType.Text));
            return projectStatusNames;
        }

        //public Task<List<ProjectStatusName>> FetchAll(long isbn)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}