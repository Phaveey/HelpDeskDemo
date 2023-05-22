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
        Task<IEnumerable<Users>> GetAllAsync(bool trackChanges);
        Task<Users> GetUsersById(int Id, bool trackChanges);
        void CreateUsers(Users entity);
        void UpdateUsers(Users entity);
        void DeleteUsers(Users entity);
    }
}
