using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public void CreateUsers(Users users)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsers(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetAllUsersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUsers(string UsersName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
