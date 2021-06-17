//using Trust.Interfaces;
//using Trust.Entities;
//using Dapper;
//using System.Collections.Generic;
//using System.Data;
//using System.Threading.Tasks;
//namespace Trust.Data
//{
//    public class TeamAssignUserService : ITeamAssignUserService
//    {
//        private readonly IDapperService _dapperService;
//        public TeamAssignUserService(IDapperService dapperService)
//        {
//            this._dapperService = dapperService;
//        }
//        public Task<int> Create(TeamAssignUserName teamAssignUserName)
//        {
//            var dbPara = new DynamicParameters();

//            dbPara.Add("UserId", teamAssignUserName.UserId);


//            var teamAssignUserId = Task.FromResult(_dapperService.
//                Insert<int>("[dbo].[spAddTeamAssignUser]", dbPara,
//                commandType: CommandType.StoredProcedure));
//            return teamAssignUserId;
//        }
//        public Task<int> Delete(int AssignId, int UserId)
//        {
//            var deleteTeamAssignUser = Task.FromResult(_dapperService.
//                Execute($"Delete [TeamAssignUser] where AssignId = {AssignId} " +
//                $"and UserId = {UserId}", null,
//                commandType: CommandType.Text));
//            return deleteTeamAssignUser;
//        }
//        public Task<List<TeamAssignUserName>> FetchAll(int AssignId)
//        {
//            var teamAssignUserNames = Task.FromResult(_dapperService.GetAll
//                <TeamAssignUserName>($"select * from TeaId " +
//                $"({AssignId}) order by UserId; ", null,
//                commandType: CommandType.Text));
//            return teamAssignUserNames;
//        }

//        //public Task<List<ProjectStatusName>> FetchAll(long isbn)
//        //{
//        //    throw new System.NotImplementedException();
//        //}
//    }
//}