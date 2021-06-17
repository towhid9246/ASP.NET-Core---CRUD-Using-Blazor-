using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class TeamAssignService : ITeamAssignService
    {
        private readonly IDapperService _dapperService;
        public TeamAssignService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(TeamAssign teamAssign)
        {
            var dbPara = new DynamicParameters();

         
            dbPara.Add("UserId", teamAssign.UserId);
            var teamAssignId = Task.FromResult(_dapperService.
                Insert<int>("[dbo].[spAddTeamAssigns]", dbPara,
                commandType: CommandType.StoredProcedure));
            return teamAssignId;
        }
        public Task<TeamAssign> GetById(int AssignId)
        {
            var teamAssign = Task.FromResult(_dapperService.Get<TeamAssign>
                ($"select * from [TeamAssigns] where AssignId = {AssignId}",
                null, commandType: CommandType.Text));
            return teamAssign;
        }
        public Task<int> Update(TeamAssign teamAssign)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AssignId", teamAssign.AssignId);


            dbPara.Add("UserId", teamAssign.UserId);
            var updateTeamAssign = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateTeamAssigns]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateTeamAssign;
        }
        public Task<int> Delete(int AssignId)
        {
            var deleteTeamAssign = Task.FromResult(_dapperService.Execute
                ($"Delete [TeamAssigns] where AssignId = {AssignId}", null,
                commandType: CommandType.Text));
            return deleteTeamAssign;
        }
        public Task<int> Count(string search)
        {
            var totTeamAssign = Task.FromResult(_dapperService.Get<int>
               ($"select COUNT(*) from [TeamAssigns] " +
               $"WHERE UserId like '%{search}%'", null,
               commandType: CommandType.Text));
            return totTeamAssign;
        }
        public Task<List<TeamAssignUs>> ListAll(int skip,
               int take, string orderBy, string direction = "DESC",
               string search = "")
        {
            var teamAssigns = Task.FromResult(_dapperService.GetAll<TeamAssignUs>($"SELECT t.*, u.UserName UserName FROM TeamAssigns t LEFT OUTER JOIN Users u ON t.UserId = u.UserId WHERE AssignId like '%{search}%'ORDER BY { orderBy} { direction} OFFSET { skip} ROWS FETCH NEXT { take} ROWS ONLY; ", null,


          commandType: CommandType.Text));
            return teamAssigns;
        }

        //public Task<List<TeamAssign>> FetchAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<List<TeamAssignTeUs>> FetchAll()
        //{
        //    var teamAssigns = Task.FromResult
        //        (_dapperService.GetAll<TeamAssignTeUs>
        //        ($"SELECT * FROM [TeamAssign] ORDER BY AssignId; ",
        //        null, commandType: CommandType.Text));
        //    return teamAssigns;
        //}

        //Task<List<TeamAssign>> ITeamAssignService.FetchAll()
        //{
        //    throw new System.NotImplementedException();
        //}



        //public Task<List<TeamAssign>> FetchAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<int> Update(TeamAssign teamAssign)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<int> Update(TeamAssign teamAssign)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<List<TeamAssign>> FetchAll()
        //{
        //    throw new System.NotImplementedException();
        //}

        //Task<List<TeamAssign>> ITeamAssignService.ListAll(int skip, int take, string orderBy, string direction, string search)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
