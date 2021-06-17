using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class TeamService : ITeamService
    {
        private readonly IDapperService _dapperService;
        public TeamService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(Team team)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TeamName", team.TeamName, DbType.String);
            dbPara.Add("TeamDesc", team.TeamDesc, DbType.String);
            dbPara.Add("TeamStatus", team.TeamStatus, DbType.String);
            var teamId = Task.FromResult(_dapperService.Insert<int>
                ("[dbo].[spAddTeams]", dbPara,
                commandType: CommandType.StoredProcedure));
            return teamId;
        }
        public Task<Team> ReadByPk(int TeamId)
        {
            var team= Task.FromResult(_dapperService.Get<Team>
                ($"select * from [Teams] where TeamId = {TeamId}", null,
                commandType: CommandType.Text));
            return team;
        }
        public Task<int> Update(Team team)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TeamId", team.TeamId);
            dbPara.Add("TeamName", team.TeamName, DbType.String);
            dbPara.Add("TeamDesc", team.TeamDesc, DbType.String);
            dbPara.Add("TeamStatus", team.TeamStatus, DbType.String);
            var updateTeam = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateTeams]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateTeam;
        }
        public Task<int> Delete(int TeamId)
        {
            var deleteTeam = Task.FromResult(_dapperService.Execute
                ($"Delete [Teams] where TeamId = {TeamId}", null,
                commandType: CommandType.Text));
            return deleteTeam;
        }
        public Task<int> Count(string search)
        {
            var totTeam = Task.FromResult(_dapperService.Get<int>
                ($"select COUNT(*) from [Teams] WHERE TeamName like " +
                $"'%{search}%'", null, commandType: CommandType.Text));
            return totTeam;
        }
        public Task<List<Team>> ListAll(int skip, int take,
               string orderBy, string direction = "DESC",
               string search = "")
        {
            var teams = Task.FromResult(_dapperService.GetAll<Team>
                ($"SELECT * FROM [Teams] WHERE TeamName like " +
                $"'%{search}%' ORDER BY {orderBy} {direction} " +
                $"OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ",
                null, commandType: CommandType.Text));
            return teams;
        }

        public Task<List<Team>> FetchAll()
        {
            var teams = Task.FromResult
                (_dapperService.GetAll<Team>
                ($"SELECT * FROM [Teams] ORDER BY TeamName; ",
                null, commandType: CommandType.Text));
            return teams;
        }

        //public Task<Team> GetById(int TeamId)
        //{
        //    throw new System.NotImplementedException();
        //}


        //Task<List<Team>> ITeamService.ListAll(int skip, int take, string orderBy, string direction, string search)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}