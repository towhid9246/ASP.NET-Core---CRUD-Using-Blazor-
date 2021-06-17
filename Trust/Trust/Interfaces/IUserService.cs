using Trust.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Trust.Interfaces
{
    public interface IUserService
    {
        Task<int> Create(User user);
        Task<User> GetById(int UserId);
        Task<int> Update(User user);
        Task<int> Delete(int UserId);
        Task<int> Count(string search);
        Task<List<User>> FetchAll();
        Task<List<User>> ListAll(int skip,
                                   int take,
                                   string orderBy,
                                   string direction,
                                   string search);
    }
}
