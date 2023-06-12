using HelpDeskDemo.Application.Common;
using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext; 
        private readonly Lazy<IEquipmentRepository>  _equipmentRepository;
        private readonly Lazy<IProblemsRepository> _problemsRepository;
        private readonly Lazy<IProblem_HistoryRepository> _problemHistoryRepository;


        public RepositoryManager(RepositoryContext repositoryContext) 
        {
            _repositoryContext = repositoryContext;
            _equipmentRepository = new Lazy<IEquipmentRepository>(() => new EquipmentRepository(repositoryContext));
            _problemsRepository = new Lazy<IProblemsRepository>(() => new ProblemsRepository(repositoryContext));
            _problemHistoryRepository = new Lazy<IProblem_HistoryRepository>(() => new Problem_HistoryRepository(repositoryContext));

        }

        public IEquipmentRepository EquipmentRepository => _equipmentRepository.Value;
        public IProblemsRepository ProblemsRepository => _problemsRepository.Value;
        public IProblem_HistoryRepository Problem_History => _problemHistoryRepository.Value;
        public async Task SaveAsync() 
        {
            await _repositoryContext.SaveChangesAsync();
        }


        public IProblem_HistoryRepository Problem_HistoryRepository => throw new NotImplementedException();

        public IRef_Equipment_TypesRepository Ref_EquipmentRepository => throw new NotImplementedException();

        public IRef_Priority_LevelsRepository Ref_Priority_LevelsRepository => throw new NotImplementedException();

        public IRef_Problem_Status_CodesRepository Ref_Problem_Status_CodeRepository => throw new NotImplementedException();

        public IRef_Skill_CodesRepository Ref_Skill_CodesRepository => throw new NotImplementedException();

        public IRef_User_TypesRepository Ref_User_TypesRepository => throw new NotImplementedException();

        public IResolutionRepository ResolutionRepository => throw new NotImplementedException();

        public IStaff_SkillsRepository Staff_SkillsRepository => throw new NotImplementedException();

        public ISupport_StaffRepository Support_StaffRepository => throw new NotImplementedException();

        public IUsersRepository UsersRepository => throw new NotImplementedException();
    }
}
