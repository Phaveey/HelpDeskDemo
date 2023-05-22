﻿using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IStaffSkillsRepository
    {
        Task<IEnumerable<Staff_Skills>> GetAllAsync(bool trackChanges);
        Task<Staff_Skills> GetStaffSkillsByStaffIdAndStaffCode(int Id, string Code, bool trackChanges);
        void CreateStaffSkills(Staff_Skills entity);
        void UpdateStaffSkills(Staff_Skills entity);
        void DeleteStaffSkills(Staff_Skills entity);
    }
}
