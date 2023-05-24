﻿// <auto-generated />
using System;
using HelpDeskDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HelpDeskDemo.Persistence.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230524115008_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"));

                    b.Property<DateTime>("AquiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DisposeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EquipmentCode")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Type_code")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ref_Equipment_TypesEquipmentTypeCode")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId");

                    b.HasIndex("ref_Equipment_TypesEquipmentTypeCode");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Problem_History", b =>
                {
                    b.Property<int>("Problem_HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Problem_HistoryId"));

                    b.Property<int>("Assign_Staff_Id")
                        .HasColumnType("int");

                    b.Property<string>("Fix_DateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Problem_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProblemsProblemId")
                        .HasColumnType("int");

                    b.Property<int>("Prority_LevelCode")
                        .HasColumnType("int");

                    b.Property<string>("Status_Code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Problem_HistoryId");

                    b.HasIndex("ProblemsProblemId");

                    b.ToTable("Problem_History");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Problems", b =>
                {
                    b.Property<int>("ProblemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProblemId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Problem_Reported_DateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUser_Id")
                        .HasColumnType("int");

                    b.HasKey("ProblemId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("UsersUser_Id");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_Equipment_Types", b =>
                {
                    b.Property<int>("EquipmentTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentTypeCode"));

                    b.Property<string>("Equipment_TypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentTypeCode");

                    b.ToTable("Ref_Equipment_Types");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_Priority_Levels", b =>
                {
                    b.Property<int>("Priority_Level_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Priority_Level_Code"));

                    b.Property<string>("Priority_Level_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Priority_Level_Code");

                    b.ToTable("Ref_Priority_Levels");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_Problem_Status_Codes", b =>
                {
                    b.Property<int>("ProblemStatusCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProblemStatusCode"));

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProblemStatusCode");

                    b.ToTable("Ref_Problem_Stataus_Code");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_Skill_Codes", b =>
                {
                    b.Property<string>("SkillCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillCode");

                    b.ToTable("Ref_Skill_Codes");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_User_Types", b =>
                {
                    b.Property<int>("UserTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeCode"));

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeCode");

                    b.ToTable("Ref_User_Types");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Resolution", b =>
                {
                    b.Property<int>("Resolution_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Resolution_Id"));

                    b.Property<int?>("Problem_HistoryId")
                        .HasColumnType("int");

                    b.Property<int>("Problem_History_Id")
                        .HasColumnType("int");

                    b.Property<string>("Resolution_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Resolution_Id");

                    b.HasIndex("Problem_HistoryId");

                    b.ToTable("Resolution");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Staff_Skills", b =>
                {
                    b.Property<int>("Staff_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Staff_Code"));

                    b.Property<int>("Date_Skilled_Obtained")
                        .HasColumnType("int");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("int");

                    b.HasKey("Staff_Code");

                    b.ToTable("Staff_Skills");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Support_Staff", b =>
                {
                    b.Property<int>("Staff_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Staff_Id"));

                    b.Property<int>("Date_Joined")
                        .HasColumnType("int");

                    b.Property<int>("Date_Left")
                        .HasColumnType("int");

                    b.Property<string>("Staff_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Staff_Id");

                    b.ToTable("Support_Staff");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Users", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other_user_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ref_User_TypesUserTypeCode")
                        .HasColumnType("int");

                    b.Property<string>("User_EmailAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Type_Code")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.HasIndex("Ref_User_TypesUserTypeCode");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Equipment", b =>
                {
                    b.HasOne("HelpDeskDemo.Domain.Entities.Ref_Equipment_Types", "ref_Equipment_Types")
                        .WithMany()
                        .HasForeignKey("ref_Equipment_TypesEquipmentTypeCode");

                    b.Navigation("ref_Equipment_Types");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Problem_History", b =>
                {
                    b.HasOne("HelpDeskDemo.Domain.Entities.Problems", "Problems")
                        .WithMany()
                        .HasForeignKey("ProblemsProblemId");

                    b.Navigation("Problems");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Problems", b =>
                {
                    b.HasOne("HelpDeskDemo.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Problems")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HelpDeskDemo.Domain.Entities.Users", "Users")
                        .WithMany("Problems")
                        .HasForeignKey("UsersUser_Id");

                    b.Navigation("Equipment");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Resolution", b =>
                {
                    b.HasOne("HelpDeskDemo.Domain.Entities.Problem_History", null)
                        .WithMany("Resolutions")
                        .HasForeignKey("Problem_HistoryId");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Users", b =>
                {
                    b.HasOne("HelpDeskDemo.Domain.Entities.Ref_User_Types", "Ref_User_Types")
                        .WithMany("Users")
                        .HasForeignKey("Ref_User_TypesUserTypeCode");

                    b.Navigation("Ref_User_Types");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Equipment", b =>
                {
                    b.Navigation("Problems");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Problem_History", b =>
                {
                    b.Navigation("Resolutions");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Ref_User_Types", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("HelpDeskDemo.Domain.Entities.Users", b =>
                {
                    b.Navigation("Problems");
                });
#pragma warning restore 612, 618
        }
    }
}
