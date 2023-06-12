using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAllUsersAsync(bool trackChanges);

        Task<Users> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Users> GetUsers(string UsersName, bool trackChanges);

        void CreateUsers(Users users);

        void DeleteUsers(Users users);
    }
}
