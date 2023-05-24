using HelpDeskDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions option) : base(option)
        {
            
        }  

        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Problem_History> problem_Histories { get; set; }
        public DbSet<Problems> Problems { get; set; }
        public DbSet<Ref_Equipment_Types> Ref_Equipment_Types { get; set; }
        public DbSet<Ref_Priority_Levels> Ref_Priority_Levels { get; set; }
        public DbSet<Ref_Problem_Status_Codes> Ref_Problem_Status_Codes { get; set; }
        public DbSet<Ref_Skill_Codes> Ref_Skill_Codes { get;set; }
        public DbSet<Ref_User_Types> Ref_User_Types { get;set; }
        public DbSet<Resolution> Resolutions { get; set; }  
        public DbSet<Staff_Skills> Staff_Skills { get; set; }
        public DbSet<Support_Staff> Support_Staffs { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
