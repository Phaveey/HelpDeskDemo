using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpDeskDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref_Equipment_Types",
                columns: table => new
                {
                    EquipmentTypeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Equipment_Types", x => x.EquipmentTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Priority_Levels",
                columns: table => new
                {
                    Priority_Level_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority_Level_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Priority_Levels", x => x.Priority_Level_Code);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Problem_Stataus_Code",
                columns: table => new
                {
                    ProblemStatusCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Problem_Stataus_Code", x => x.ProblemStatusCode);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Skill_Codes",
                columns: table => new
                {
                    SkillCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Skill_Codes", x => x.SkillCode);
                });

            migrationBuilder.CreateTable(
                name: "Ref_User_Types",
                columns: table => new
                {
                    UserTypeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_User_Types", x => x.UserTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "Staff_Skills",
                columns: table => new
                {
                    Staff_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Date_Skilled_Obtained = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Skills", x => x.Staff_Code);
                });

            migrationBuilder.CreateTable(
                name: "Support_Staff",
                columns: table => new
                {
                    Staff_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Joined = table.Column<int>(type: "int", nullable: false),
                    Date_Left = table.Column<int>(type: "int", nullable: false),
                    Staff_FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Support_Staff", x => x.Staff_Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_code = table.Column<int>(type: "int", nullable: false),
                    AquiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisposeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    ref_Equipment_TypesEquipmentTypeCode = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipment_Ref_Equipment_Types_ref_Equipment_TypesEquipmentTypeCode",
                        column: x => x.ref_Equipment_TypesEquipmentTypeCode,
                        principalTable: "Ref_Equipment_Types",
                        principalColumn: "EquipmentTypeCode");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Type_Code = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_EmailAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_user_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ref_User_TypesUserTypeCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                    table.ForeignKey(
                        name: "FK_Users_Ref_User_Types_Ref_User_TypesUserTypeCode",
                        column: x => x.Ref_User_TypesUserTypeCode,
                        principalTable: "Ref_User_Types",
                        principalColumn: "UserTypeCode");
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    ProblemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Problem_Reported_DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProblemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    UsersUser_Id = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.ProblemId);
                    table.ForeignKey(
                        name: "FK_Problems_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Problems_Users_UsersUser_Id",
                        column: x => x.UsersUser_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Problem_History",
                columns: table => new
                {
                    Problem_HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prority_LevelCode = table.Column<int>(type: "int", nullable: false),
                    Problem_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assign_Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Fix_DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProblemsProblemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem_History", x => x.Problem_HistoryId);
                    table.ForeignKey(
                        name: "FK_Problem_History_Problems_ProblemsProblemId",
                        column: x => x.ProblemsProblemId,
                        principalTable: "Problems",
                        principalColumn: "ProblemId");
                });

            migrationBuilder.CreateTable(
                name: "Resolution",
                columns: table => new
                {
                    Resolution_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Problem_History_Id = table.Column<int>(type: "int", nullable: false),
                    Resolution_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Problem_HistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolution", x => x.Resolution_Id);
                    table.ForeignKey(
                        name: "FK_Resolution_Problem_History_Problem_HistoryId",
                        column: x => x.Problem_HistoryId,
                        principalTable: "Problem_History",
                        principalColumn: "Problem_HistoryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ref_Equipment_TypesEquipmentTypeCode",
                table: "Equipment",
                column: "ref_Equipment_TypesEquipmentTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Problem_History_ProblemsProblemId",
                table: "Problem_History",
                column: "ProblemsProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_EquipmentId",
                table: "Problems",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_UsersUser_Id",
                table: "Problems",
                column: "UsersUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Resolution_Problem_HistoryId",
                table: "Resolution",
                column: "Problem_HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Ref_User_TypesUserTypeCode",
                table: "Users",
                column: "Ref_User_TypesUserTypeCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_Priority_Levels");

            migrationBuilder.DropTable(
                name: "Ref_Problem_Stataus_Code");

            migrationBuilder.DropTable(
                name: "Ref_Skill_Codes");

            migrationBuilder.DropTable(
                name: "Resolution");

            migrationBuilder.DropTable(
                name: "Staff_Skills");

            migrationBuilder.DropTable(
                name: "Support_Staff");

            migrationBuilder.DropTable(
                name: "Problem_History");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ref_Equipment_Types");

            migrationBuilder.DropTable(
                name: "Ref_User_Types");
        }
    }
}
