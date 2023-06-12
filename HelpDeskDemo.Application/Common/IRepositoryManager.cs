using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Common
{
    public interface IRepositoryManager
    {
        
        public IEquipmentRepository   EquipmentRepository{ get; }

        public IProblem_HistoryRepository Problem_HistoryRepository { get; }

        public IProblemsRepository ProblemsRepository { get; }

        public IRef_Equipment_TypesRepository Ref_EquipmentRepository { get; }

        public IRef_Priority_LevelsRepository Ref_Priority_LevelsRepository { get; }

        public IRef_Problem_Status_CodesRepository Ref_Problem_Status_CodeRepository { get; }

        public IRef_Skill_CodesRepository Ref_Skill_CodesRepository { get; }

        public IRef_User_TypesRepository Ref_User_TypesRepository { get; }

        public IResolutionRepository ResolutionRepository { get; }

        public IStaff_SkillsRepository Staff_SkillsRepository { get; }

        public ISupport_StaffRepository Support_StaffRepository { get; }

        public IUsersRepository UsersRepository { get; }

        Task SaveAsync();
    }
}
