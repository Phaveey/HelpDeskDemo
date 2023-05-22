using HelpDeskDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Common
{
    public interface IRepositoryManager
    {
        IEquipmentRepository EquipmentRepository { get; }
        IProblemHistoryRepository ProblemHistoryRepository { get; }
        IProblemsRepository ProblemsRepository { get; }
        IRefEquipmentTypesRepository RefEquipmentTypesRepository { get; }
        IRefPriorityLevelsRepository RefPriorityLevelsRepository { get; }
        IRefProblemStatusCodesRepository RefProblemStatusCodesRepository { get; }
        IRefSkillCodesRepository RefSkillCodesRepository { get; }
        IResolutionRepository ResolutionRepository { get; }
        IStaffSkillsRepository StaffSkillsRepository { get; }
        ISupportStaffRepository SupportStaffRepository { get; }
        IUsersRepository UsersRepository { get; }
        Task SaveAsync();
    }
}
