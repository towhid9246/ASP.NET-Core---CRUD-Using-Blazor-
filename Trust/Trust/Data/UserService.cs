using Trust.Interfaces;
using Trust.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Trust.Data
{
    public class UserService : IUserService
    {
        private readonly IDapperService _dapperService;
        public UserService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }
        public Task<int> Create(User user)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserName", user.UserName, DbType.String);
            dbPara.Add("Password", user.Password, DbType.String);

            var userId = Task.FromResult(_dapperService.Insert<int>
                ("[dbo].[spAddUsers]", dbPara,
                commandType: CommandType.StoredProcedure));
            return userId;
        }
        public Task<User> GetById(int UserId)
        {
            var user = Task.FromResult(_dapperService.Get<User>
                ($"select * from [Users] where UserId = {UserId}", null,
                commandType: CommandType.Text));
            return user;
        }
        public Task<int> Update(User user)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserId", user.UserId);
            dbPara.Add("UserName", user.UserName, DbType.String);
            dbPara.Add("Password", user.Password, DbType.String);

            var updateUser = Task.FromResult(_dapperService.
                Update<int>("[dbo].[spUpdateUsers]", dbPara,
                commandType: CommandType.StoredProcedure));
            return updateUser;
        }
        public Task<int> Delete(int UserId)
        {
            var deleteUser = Task.FromResult(_dapperService.Execute
                ($"Delete [Users] where UserId = {UserId}", null,
                commandType: CommandType.Text));
            return deleteUser;
        }
        public Task<int> Count(string search)
        {
            var totUser = Task.FromResult(_dapperService.Get<int>
                ($"select COUNT(*) from [Users] WHERE UserName like " +
                $"'%{search}%'", null, commandType: CommandType.Text));
            return totUser;
        }
        public Task<List<User>> ListAll(int skip, int take,
               string orderBy, string direction = "DESC",
               string search = "")
        {
            var users = Task.FromResult(_dapperService.GetAll<User>
                ($"SELECT * FROM [Users] WHERE UserName like " +
                $"'%{search}%' ORDER BY {orderBy} {direction} " +
                $"OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ",
                null, commandType: CommandType.Text));
            return users;
        }

        public Task<List<User>> FetchAll()
        {
            var users = Task.FromResult
                (_dapperService.GetAll<User>
                ($"SELECT * FROM [Users] ORDER BY Name; ",
                null, commandType: CommandType.Text));
            return users;
        }




    }
}