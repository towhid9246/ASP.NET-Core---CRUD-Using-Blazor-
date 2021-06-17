using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class ProjectService : IProjectService
    {
        private readonly IDapperService _dapperService;
        public ProjectService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(Project project)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ProjectName", project.ProjectName, DbType.String);
            dbPara.Add("ProjectDesc", project.ProjectDesc, DbType.String);
            dbPara.Add("ProjectStart", project.ProjectStart, DbType.Date);
            dbPara.Add("ProjectEnd", project.ProjectEnd, DbType.Date);
            dbPara.Add("ProjectDeadline", project.ProjectDeadline, DbType.Date);
            dbPara.Add("TeaId", project.TeaId, DbType.Int32);

            var projectId = Task.FromResult(_dapperService.Insert<int>
                ("[dbo].[spAddProjects]", dbPara,
                commandType: CommandType.StoredProcedure));
            return projectId;
        }
        public Task<Project> GetById(int ProjectId)
        {
            var project = Task.FromResult(_dapperService.Get<Project>
                ($"select * from [Projects] where ProjectId = {ProjectId}", null,
                commandType: CommandType.Text));
            return project;
        }
        public Task<int> Update(Project project, int pk)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ProjectId", project.ProjectId, DbType.Int64);
            dbPara.Add("ProjectName", project.ProjectName, DbType.String);
            dbPara.Add("ProjectDesc", project.ProjectDesc, DbType.String);
            dbPara.Add("ProjectStart", project.ProjectStart, DbType.Date);
            dbPara.Add("ProjectEnd", project.ProjectEnd, DbType.Date);
            dbPara.Add("ProjectDeadline", project.ProjectDeadline, DbType.Date);
            dbPara.Add("TeaId", project.TeaId, DbType.Int32);
            dbPara.Add("Pk", pk, DbType.Int64);
            var updateProject = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateProjects]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateProject;
        }
        public Task<int> Delete(int ProjectId)
        {
            var deleteProject = Task.FromResult(_dapperService.Execute
                ($"Delete [Projects] where ProjectId = {ProjectId}", null,
                commandType: CommandType.Text));
            return deleteProject;
        }
        public Task<int> Count(string search)
        {
            var totProject = Task.FromResult(_dapperService.Get<int>
                ($"select COUNT(*) from [Projects] WHERE ProjectName like " +
                $"'%{search}%'", null, commandType: CommandType.Text));
            return totProject;
        }
        public Task<List<Project>> FetchAll()
        {
            var projects = Task.FromResult
                (_dapperService.GetAll<Project>
                ($"SELECT * FROM [Projects] ORDER BY ProjectName; ",
                null, commandType: CommandType.Text));
            return projects;
        }
        //public Task<List<Project>> ListAll(int skip, int take,
        //       string orderBy, string direction = "DESC",
        //       string search = "")
        //{
        //    var projects = Task.FromResult(_dapperService.GetAll<Project>
        //        ($"SELECT * FROM [Projects] WHERE ProjectName like " +
        //        $"'%{search}%' ORDER BY {orderBy} {direction} " +
        //        $"OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ",
        //        null, commandType: CommandType.Text));
        //    return projects;
        //}
        public Task<List<ProjectStTea>> ListAll(int skip,
             int take, string orderBy, string direction = "DESC",
             string search = "")
        {
            var projects = Task.FromResult(_dapperService.
             GetAll<ProjectStTea>(@"SELECT P.ProjectId, ProjectName, ProjectDesc, ProjectStart, ProjectEnd, ProjectDeadline, TeaId, T.TeamId,
            T.TeamName, S.StatusId, S.StatusName
            FROM Projects P
            INNER JOIN
            Teams T
            ON P.TeaId = T.TeamId
            INNER JOIN
            [dbo].[Status] PS
            ON P.StatusID = PS.StatusId
            INNER JOIN
            Status S ON PS.StatusId = S.StatusId;", null, commandType: CommandType.Text));
            return projects;
        }

        //public Task<int> Delete(long ProjectId)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<List<Project>> FetchAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<Project> GetById(int ProjectId)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}