using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace Trust.Data
{
    public class StatusService : IStatusService
    {
        private readonly IDapperService _dapperService;
        public StatusService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(Status status)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("StatusName", status.StatusName, DbType.String);
            dbPara.Add("StatusType", status.StatusType, DbType.String);

            var statusId = Task.FromResult(_dapperService.Insert<int>
                ("[dbo].[spAddStatus]", dbPara,
                commandType: CommandType.StoredProcedure));
            return statusId;
        }
        public Task<Status> GetById(int StatusId)
        {
            var status = Task.FromResult(_dapperService.Get<Status>
                ($"select * from [Status] where StatusId = {StatusId}", null,
                commandType: CommandType.Text));
            return status;
        }
        public Task<int> Update(Status status)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("StatusId", status.StatusId);
            dbPara.Add("StatusName", status.StatusName, DbType.String);
            dbPara.Add("StatusType", status.StatusType, DbType.String);

            var updateStatus = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateStatus]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateStatus;
        }
        public Task<int> Delete(int StatusId)
        {
            var deleteStatus = Task.FromResult(_dapperService.Execute
                ($"Delete [Status] where StaId = {StatusId}", null,
                commandType: CommandType.Text));
            return deleteStatus;
        }
        public Task<int> Count(string search)
        {
            var totStatus = Task.FromResult(_dapperService.Get<int>
                ($"select COUNT(*) from [Status] WHERE StatusName like " +
                $"'%{search}%'", null, commandType: CommandType.Text));
            return totStatus;
        }
        public Task<List<Status>> ListAll(int skip, int take,
               string orderBy, string direction = "DESC",
               string search = "")
        {
            var statuss = Task.FromResult(_dapperService.GetAll<Status>
                ($"SELECT * FROM [Status] WHERE StatusName like " +
                $"'%{search}%' ORDER BY {orderBy} {direction} " +
                $"OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ",
                null, commandType: CommandType.Text));
            return statuss;
        }

        public Task<List<Status>> FetchAll()
        {
            var statuss = Task.FromResult
                (_dapperService.GetAll<Status>
                ($"SELECT * FROM [Status] ORDER BY StatusId; ",
                null, commandType: CommandType.Text));
            return statuss;
        }

        //public Task<int> Create(Status status)
        //{
        //    throw new System.NotImplementedException();
        //}

        //Task<Status> IStatusService.ReadByPk(int StatusId)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task<int> Update(Status status)
        //{
        //    throw new System.NotImplementedException();
        //}

        //Task<List<Status>> IStatusService.ListAll(int skip, int take, string orderBy, string direction, string search)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}