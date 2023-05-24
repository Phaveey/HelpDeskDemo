using HelpDeskDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Common
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff_Skills>()
                .HasKey(e =>new { e.Staff_Id });
            modelBuilder.Entity<Staff_Skills>()
                .HasKey(e => new { e.Staff_Code });
        }
        DbSet<Equipment> Equipment { get; set; }
        DbSet<Problem_History> Problem_History { get; set; }
        DbSet<Problems> Problems { get; set; }
        DbSet<Ref_Equipment_Types> Ref_Equipment_Types { get; set; }
        DbSet<Ref_Priority_Levels> Ref_Priority_Levels { get; set; }
        DbSet<Ref_Problem_Status_Codes> Ref_Problem_Stataus_Code { get; set; }
        DbSet<Ref_Skill_Codes> Ref_Skill_Codes { get; set; }
        DbSet<Ref_User_Types> Ref_User_Types { get; set; }
        DbSet<Resolution> Resolution { get; set; }
        DbSet<Staff_Skills> Staff_Skills { get; set; }
        DbSet<Support_Staff> Support_Staff { get; set; }
        DbSet<Users> Users { get; set; }
    }
}
