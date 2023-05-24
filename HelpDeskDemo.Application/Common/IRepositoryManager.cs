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
        public IEquipment   Equipment{ get; }
        public IProblem_History Problem_HistoryRepository { get; }
        public IProblems ProblemsRepository { get; }
        public IRef_Equipment_Types Ref_EquipmentRepository { get; }
        public IRef_Priority_Levels Ref_Priority_LevelsRepository { get; }
        public IRef_Problem_Status_Codes Ref_Problem_Status_CodeRepository { get; }
        public IRef_Skill_Codes Ref_Skill_CodesRepository { get; }
        public IRef_User_Types Ref_User_TypesRepository { get; }
        public IResolution ResolutionRepository { get; }
        public IStaff_Skills Staff_SkillsRepository { get; }
        public ISupport_Staff Support_StaffRepository { get; }
        public IUsers UsersRepository { get; }
        void Save();
    }
}
