using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Troual.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 412, DateTimeKind.Local).AddTicks(6468)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControllerEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleFr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 426, DateTimeKind.Local).AddTicks(5221)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostCategoryEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 415, DateTimeKind.Local).AddTicks(1264)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCategoryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralParameters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<long>(type: "bigint", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralParameters_GeneralParameters_ParentID",
                        column: x => x.ParentID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobEntities",
                columns: table => new
                {
                    JobEntityID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExecutedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 423, DateTimeKind.Local).AddTicks(2415)),
                    WeighProductInCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<long>(type: "bigint", nullable: false),
                    WeightInCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobEntities", x => x.JobEntityID);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDefinitionEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDefinitionEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockRoomEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nVarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockRoomEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tableInfoEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastInsertedCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableInfoEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionsEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleFr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 427, DateTimeKind.Local).AddTicks(9653)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionsEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionsEntities_ControllerEntities_ControllerEntityID",
                        column: x => x.ControllerEntityID,
                        principalTable: "ControllerEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControllerRoleEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerEntityID = table.Column<long>(type: "bigint", nullable: false),
                    RoleEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerRoleEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControllerRoleEntities_AspNetRoles_RoleEntityID",
                        column: x => x.RoleEntityID,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControllerRoleEntities_ControllerEntities_ControllerEntityID",
                        column: x => x.ControllerEntityID,
                        principalTable: "ControllerEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    CostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CostAmount = table.Column<long>(type: "bigint", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    RemainingMonth = table.Column<int>(type: "int", nullable: false),
                    CalculationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 416, DateTimeKind.Local).AddTicks(5742)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostEntity_CostCategoryEntity_CostCategoryID",
                        column: x => x.CostCategoryID,
                        principalTable: "CostCategoryEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 361, DateTimeKind.Local).AddTicks(5232)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryPerHour = table.Column<long>(type: "bigint", nullable: false),
                    SalaryPerMonth = table.Column<long>(type: "bigint", nullable: false),
                    MaxWorkPerHour = table.Column<long>(type: "bigint", nullable: false),
                    MaxWorkPerDay = table.Column<long>(type: "bigint", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeerTypeFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryTypeFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_GeneralParameters_EmployeerTypeFK_ID",
                        column: x => x.EmployeerTypeFK_ID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_GeneralParameters_SalaryTypeFK_ID",
                        column: x => x.SalaryTypeFK_ID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "processEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractorTypeID = table.Column<long>(type: "bigint", nullable: true),
                    ContractorFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFinalStep = table.Column<bool>(type: "bit", nullable: false),
                    processDefinitionEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_processEntities_GeneralParameters_ContractorTypeID",
                        column: x => x.ContractorTypeID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_processEntities_ProcessDefinitionEntities_processDefinitionEntityID",
                        column: x => x.processDefinitionEntityID,
                        principalTable: "ProcessDefinitionEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionsRoleEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionsEntityID = table.Column<long>(type: "bigint", nullable: false),
                    RoleEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionsRoleEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionsRoleEntity_ActionsEntities_ActionsEntityID",
                        column: x => x.ActionsEntityID,
                        principalTable: "ActionsEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionsRoleEntity_AspNetRoles_RoleEntityID",
                        column: x => x.RoleEntityID,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostJobEntities",
                columns: table => new
                {
                    CostEntityID = table.Column<long>(type: "bigint", nullable: false),
                    ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthDuration = table.Column<int>(type: "int", nullable: false),
                    JobEntityID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostJobEntities", x => x.CostEntityID);
                    table.ForeignKey(
                        name: "FK_CostJobEntities_CostEntity_CostEntityID",
                        column: x => x.CostEntityID,
                        principalTable: "CostEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostJobEntities_JobEntities_JobEntityID",
                        column: x => x.JobEntityID,
                        principalTable: "JobEntities",
                        principalColumn: "JobEntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActionsUserEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionsEntityID = table.Column<long>(type: "bigint", nullable: false),
                    UserEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionsUserEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionsUserEntity_ActionsEntities_ActionsEntityID",
                        column: x => x.ActionsEntityID,
                        principalTable: "ActionsEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionsUserEntity_AspNetUsers_UserEntityID",
                        column: x => x.UserEntityID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControllerUserEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerEntityID = table.Column<long>(type: "bigint", nullable: false),
                    UserEntityID = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerUserEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControllerUserEntity_AspNetUsers_UserEntityID",
                        column: x => x.UserEntityID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ControllerUserEntity_ControllerEntities_ControllerEntityID",
                        column: x => x.ControllerEntityID,
                        principalTable: "ControllerEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogEntities",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    IsCreated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LogEntities_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowProcessEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    processEntityID = table.Column<long>(type: "bigint", nullable: true),
                    SumLaborer = table.Column<int>(type: "int", nullable: false),
                    SumHours = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNewMaterial = table.Column<bool>(type: "bit", nullable: false),
                    IsForeignWorker = table.Column<int>(type: "int", nullable: false),
                    Hire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowProcessEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowProcessEntities_processEntities_processEntityID",
                        column: x => x.processEntityID,
                        principalTable: "processEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "processUserEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: true),
                    processEntityID = table.Column<long>(type: "bigint", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processUserEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_processUserEntities_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_processUserEntities_processEntities_processEntityID",
                        column: x => x.processEntityID,
                        principalTable: "processEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InitialBalanceEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCostPriceLog = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalUserCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeighProductInCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceBeforeCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProposedPrice = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMeaurementFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    ImageUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeMaterialFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    CategoryTypeFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    flowProcessEntityID = table.Column<long>(type: "bigint", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 374, DateTimeKind.Local).AddTicks(1565)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialBalanceEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InitialBalanceEntities_FlowProcessEntities_flowProcessEntityID",
                        column: x => x.flowProcessEntityID,
                        principalTable: "FlowProcessEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InitialBalanceEntities_GeneralParameters_CategoryTypeFK_ID",
                        column: x => x.CategoryTypeFK_ID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InitialBalanceEntities_GeneralParameters_TypeMaterialFK_ID",
                        column: x => x.TypeMaterialFK_ID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InitialBalanceEntities_GeneralParameters_UnitMeaurementFK_ID",
                        column: x => x.UnitMeaurementFK_ID,
                        principalTable: "GeneralParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FlowProcessUserSalaryEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowProcessEntityID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    processUserEntityID = table.Column<long>(type: "bigint", nullable: false),
                    SumLaborer = table.Column<int>(type: "int", nullable: false),
                    SumHours = table.Column<int>(type: "int", nullable: false),
                    SumDays = table.Column<int>(type: "int", nullable: false),
                    SalaryPerDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryPerHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowProcessUserSalaryEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowProcessUserSalaryEntities_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowProcessUserSalaryEntities_FlowProcessEntities_FlowProcessEntityID",
                        column: x => x.FlowProcessEntityID,
                        principalTable: "FlowProcessEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowProcessUserSalaryEntities_processUserEntities_processUserEntityID",
                        column: x => x.processUserEntityID,
                        principalTable: "processUserEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InitialBalanceJobEntities",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InitialBalanceEntityID = table.Column<long>(type: "bigint", nullable: false),
                    JobEntityID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PriceBeforeCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightProductInCalculation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPriceProducts = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialBalanceJobEntities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InitialBalanceJobEntities_InitialBalanceEntities_InitialBalanceEntityID",
                        column: x => x.InitialBalanceEntityID,
                        principalTable: "InitialBalanceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialBalanceJobEntities_JobEntities_JobEntityID",
                        column: x => x.JobEntityID,
                        principalTable: "JobEntities",
                        principalColumn: "JobEntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockRoom_InitialBalances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockRoom_InitialBalanceFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    InitialBalanceEntitiesFK_ID = table.Column<long>(type: "bigint", nullable: true),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    CurrentCount = table.Column<long>(type: "bigint", nullable: false),
                    PricePerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 20, 22, 43, 44, 408, DateTimeKind.Local).AddTicks(9522)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockRoom_InitialBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockRoom_InitialBalances_InitialBalanceEntities_InitialBalanceEntitiesFK_ID",
                        column: x => x.InitialBalanceEntitiesFK_ID,
                        principalTable: "InitialBalanceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockRoom_InitialBalances_StockRoomEntities_StockRoom_InitialBalanceFK_ID",
                        column: x => x.StockRoom_InitialBalanceFK_ID,
                        principalTable: "StockRoomEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WastageEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowProcessEntityID = table.Column<long>(type: "bigint", nullable: false),
                    InitialBalanceEntityID = table.Column<long>(type: "bigint", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastageEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastageEntity_FlowProcessEntities_FlowProcessEntityID",
                        column: x => x.FlowProcessEntityID,
                        principalTable: "FlowProcessEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WastageEntity_InitialBalanceEntities_InitialBalanceEntityID",
                        column: x => x.InitialBalanceEntityID,
                        principalTable: "InitialBalanceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flowProcessStockInitialEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stockRoom_InitialBalanceEntityID = table.Column<long>(type: "bigint", nullable: false),
                    FlowProcessEntityID = table.Column<long>(type: "bigint", nullable: false),
                    count = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flowProcessStockInitialEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_flowProcessStockInitialEntities_FlowProcessEntities_FlowProcessEntityID",
                        column: x => x.FlowProcessEntityID,
                        principalTable: "FlowProcessEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_flowProcessStockInitialEntities_StockRoom_InitialBalances_stockRoom_InitialBalanceEntityID",
                        column: x => x.stockRoom_InitialBalanceEntityID,
                        principalTable: "StockRoom_InitialBalances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "processBalanceEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitialBalanceID = table.Column<long>(type: "bigint", nullable: true),
                    stockRoom_InitialBalanceID = table.Column<long>(type: "bigint", nullable: true),
                    processEntityID = table.Column<long>(type: "bigint", nullable: true),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processBalanceEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_processBalanceEntities_InitialBalanceEntities_InitialBalanceID",
                        column: x => x.InitialBalanceID,
                        principalTable: "InitialBalanceEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_processBalanceEntities_processEntities_processEntityID",
                        column: x => x.processEntityID,
                        principalTable: "processEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_processBalanceEntities_StockRoom_InitialBalances_stockRoom_InitialBalanceID",
                        column: x => x.stockRoom_InitialBalanceID,
                        principalTable: "StockRoom_InitialBalances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcessBalanceStockEntities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessBalanceID = table.Column<long>(type: "bigint", nullable: false),
                    processBalanceEntityId = table.Column<long>(type: "bigint", nullable: true),
                    StockRoomID = table.Column<long>(type: "bigint", nullable: false),
                    stockRoom_InitialBalanceEntityId = table.Column<long>(type: "bigint", nullable: true),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessBalanceStockEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessBalanceStockEntities_processBalanceEntities_processBalanceEntityId",
                        column: x => x.processBalanceEntityId,
                        principalTable: "processBalanceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProcessBalanceStockEntities_StockRoom_InitialBalances_stockRoom_InitialBalanceEntityId",
                        column: x => x.stockRoom_InitialBalanceEntityId,
                        principalTable: "StockRoom_InitialBalances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ControllerEntities",
                columns: new[] { "Id", "ControllerName", "CreatedById", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "TitleEn", "TitleFr" },
                values: new object[,]
                {
                    { 1L, "AdminRole", 0L, null, true, 0L, null, "Role", "مدیریت نقش ها" },
                    { 15L, "Wasstage", 0L, null, true, 0L, null, "Wasstage", "مدیریت ضایعات" },
                    { 14L, "Controlls", 0L, null, true, 0L, null, "Permission User", "مدیریت دسترسی کاربر" },
                    { 12L, "StockRoom", 0L, null, true, 0L, null, "Stock Room", "مدیریت انبار" },
                    { 10L, "ProcessDefinition", 0L, null, true, 0L, null, "Process Definition", "مدیریت نوع فرایند" },
                    { 9L, "Process", 0L, null, true, 0L, null, "Process", "مدیریت فرایند" },
                    { 8L, "ProcessBalance", 0L, null, true, 0L, null, "ProcessBalance", "مدیریت محصولات اولیه فرایند" },
                    { 11L, "StockBalance", 0L, null, true, 0L, null, "Stock Balance", "مدیریت انبار خروجی فرایند" },
                    { 6L, "GeneralParamter", 0L, null, true, 0L, null, "GeneralParameter", "دسته بندی" },
                    { 5L, "FlowProcess", 0L, null, true, 0L, null, "FlowProcess", "مدیریت خروجی فرایند" },
                    { 4L, "Cost", 0L, null, true, 0L, null, "Cost", "مدیریت هزینه ها" },
                    { 3L, "CostCategory", 0L, null, true, 0L, null, "CostCategory", "مدیریت سرفصل هزینه ها" },
                    { 2L, "AdminUser", 0L, null, true, 0L, null, "User", "مدیریت کاربران" },
                    { 7L, "InitialBalance", 0L, null, true, 0L, null, "InitialBalance", "مدیریت  مواد اولیه" }
                });

            migrationBuilder.InsertData(
                table: "GeneralParameters",
                columns: new[] { "Id", "AddedDate", "Code", "CreatedById", "Description", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "ParentID", "Title" },
                values: new object[,]
                {
                    { 16L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4140), "0006", 0L, null, null, true, 0L, null, null, "نوع انجام فرایند" },
                    { 1L, new DateTime(2021, 3, 20, 22, 43, 44, 432, DateTimeKind.Local).AddTicks(5674), "0001", 0L, null, null, true, 0L, null, null, "واحد اندازه گیری" },
                    { 13L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(773), "0005", 0L, null, null, true, 0L, null, null, "حقوق و دستمزد" },
                    { 5L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3487), "0002", 0L, null, null, true, 0L, null, null, "نوع موارد" },
                    { 8L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3753), "0003", 0L, null, null, true, 0L, null, null, "دسته بندی" },
                    { 10L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3902), "0004", 0L, null, null, true, 0L, null, null, "نوع کارمند" },
                    { 20L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4314), "0007", 0L, null, null, true, 0L, null, null, "نوع خروجی جریان فرایند" }
                });

            migrationBuilder.InsertData(
                table: "ActionsEntities",
                columns: new[] { "Id", "ActionName", "AddedDate", "ControllerEntityID", "CreatedById", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "TitleEn", "TitleFr" },
                values: new object[,]
                {
                    { 11L, "GetById", new DateTime(2021, 3, 20, 22, 43, 44, 438, DateTimeKind.Local).AddTicks(4251), 1L, 1L, null, true, 0L, null, null, null },
                    { 73L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3514), 9L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 72L, "GetUserContractors", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3510), 9L, 1L, null, true, 0L, null, null, null },
                    { 71L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3506), 9L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 70L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3502), 9L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 69L, "EditBalance", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3492), 9L, 1L, null, true, 0L, null, null, null },
                    { 68L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3485), 9L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 67L, "Get", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3340), 9L, 1L, null, true, 0L, null, null, null },
                    { 66L, "InsertBalance", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3334), 9L, 1L, null, true, 0L, null, null, "" },
                    { 65L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3263), 9L, 1L, null, true, 0L, null, null, null },
                    { 64L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 445, DateTimeKind.Local).AddTicks(1643), 8L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 74L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3519), 9L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 63L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 445, DateTimeKind.Local).AddTicks(1588), 8L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 215L, "SearchWastage", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6046), 7L, 1L, null, true, 0L, null, null, "  مشاهده ضایعات" },
                    { 214L, "PrintWastage", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6042), 7L, 1L, null, true, 0L, null, null, "دریافت فایل اکسل ضایعات" },
                    { 213L, "GetWastage", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6038), 7L, 1L, null, true, 0L, null, null, "مشاهده لیست ضایعات" },
                    { 62L, "PrintExcel", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6035), 7L, 1L, null, true, 0L, null, null, "دریافت  اکسل محصولات نهایی" },
                    { 61L, "SearchFinalProducts", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6031), 7L, 1L, null, true, 0L, null, null, "جستجو محصولات نهایی" },
                    { 60L, "SearchAutoCompleteExceptIds", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6027), 7L, 1L, null, true, 0L, null, null, null },
                    { 58L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6019), 7L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 57L, "SearchAutoComplete", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6015), 7L, 1L, null, true, 0L, null, null, null },
                    { 56L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6011), 7L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 55L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6007), 7L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 216L, "PrintWastageExcel", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6050), 7L, 1L, null, true, 0L, null, null, "دریافت اکسل ضایعات" },
                    { 75L, "GetProcessProducts", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3523), 9L, 1L, null, true, 0L, null, null, null },
                    { 76L, "RollBackProcess", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(3527), 9L, 1L, null, true, 0L, null, null, null },
                    { 77L, "Get", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9128), 10L, 1L, null, true, 0L, null, null, null },
                    { 218L, "PrintWastageExcel", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(5547), 15L, 1L, null, true, 0L, null, null, "دریافت اکسل ضایعات" },
                    { 217L, "SearchWastage", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(5524), 15L, 1L, null, true, 0L, null, null, "  مشاهده ضایعات" },
                    { 98L, "SetGrantToUser", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(2479), 14L, 1L, null, true, 0L, null, null, "اعمال دسترسی" },
                    { 97L, "GetActionsUserGrants", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(2476), 14L, 1L, null, true, 0L, null, null, "مشاهده دسترسی داده شده" },
                    { 96L, "GetControlsUserGrants", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(2472), 14L, 1L, null, true, 0L, null, null, "مشاهده دسترسی داده شده عملیات" },
                    { 95L, "GetActions", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(2467), 14L, 1L, null, true, 0L, null, null, "مشاهده عملیات" },
                    { 94L, "GetControls", new DateTime(2021, 3, 20, 22, 43, 44, 448, DateTimeKind.Local).AddTicks(2441), 14L, 1L, null, true, 0L, null, null, "مشاهده صفحه دسترسی" },
                    { 89L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4302), 12L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 88L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4298), 12L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 87L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4289), 12L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 86L, "Get", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4285), 12L, 1L, null, true, 0L, null, null, null },
                    { 85L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4281), 12L, 1L, null, true, 0L, null, null, null },
                    { 84L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4277), 12L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 83L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(4247), 12L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 93L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(8276), 11L, 1L, null, true, 0L, null, null, "ایجاد" }
                });

            migrationBuilder.InsertData(
                table: "ActionsEntities",
                columns: new[] { "Id", "ActionName", "AddedDate", "ControllerEntityID", "CreatedById", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "TitleEn", "TitleFr" },
                values: new object[,]
                {
                    { 92L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(8272), 11L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 91L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(8267), 11L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 90L, "Get", new DateTime(2021, 3, 20, 22, 43, 44, 447, DateTimeKind.Local).AddTicks(8242), 11L, 1L, null, true, 0L, null, null, null },
                    { 82L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9186), 10L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 81L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9179), 10L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 80L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9175), 10L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 79L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9171), 10L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 78L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 446, DateTimeKind.Local).AddTicks(9167), 10L, 1L, null, true, 0L, null, null, "حذف" },
                    { 54L, "GetQuantityStock", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6000), 7L, 1L, null, true, 0L, null, null, "دریافت  ظرفیت انبار" },
                    { 53L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(5996), 7L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 59L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(6023), 7L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 51L, "EditBalanceStock", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(5988), 7L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 17L, "GetById", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6617), 4L, 1L, null, true, 0L, null, null, null },
                    { 16L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6538), 4L, 1L, null, true, 0L, null, null, null },
                    { 31L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2127), 3L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 30L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2121), 3L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 52L, "GetBalanceByID", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(5992), 7L, 1L, null, true, 0L, null, null, null },
                    { 28L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2100), 3L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 27L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2094), 3L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 26L, "GetById", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2086), 3L, 1L, null, true, 0L, null, null, null },
                    { 25L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(1992), 3L, 1L, null, true, 0L, null, null, null },
                    { 10L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4749), 2L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 9L, "Login", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4741), 2L, 1L, null, true, 0L, null, null, null },
                    { 8L, "ChangePassword", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4735), 2L, 1L, null, true, 0L, null, null, "تغییر پسورد" },
                    { 7L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4729), 2L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 6L, "Active", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4723), 2L, 1L, null, true, 0L, null, null, null },
                    { 5L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4709), 2L, 1L, null, true, 0L, null, null, "ایجاد کردن" },
                    { 4L, "GetUsers", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4702), 2L, 1L, null, true, 0L, null, null, "مشاهده همه کاربران" },
                    { 3L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4695), 2L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 2L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(4666), 2L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 1L, "GetById", new DateTime(2021, 3, 20, 22, 43, 44, 437, DateTimeKind.Local).AddTicks(3549), 2L, 1L, null, true, 0L, null, null, null },
                    { 15L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 438, DateTimeKind.Local).AddTicks(4435), 1L, 1L, null, true, 0L, null, null, null },
                    { 14L, "GetRoles", new DateTime(2021, 3, 20, 22, 43, 44, 438, DateTimeKind.Local).AddTicks(4429), 1L, 1L, null, true, 0L, null, null, null },
                    { 13L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 438, DateTimeKind.Local).AddTicks(4421), 1L, 1L, null, true, 0L, null, null, null },
                    { 12L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 438, DateTimeKind.Local).AddTicks(4325), 1L, 1L, null, true, 0L, null, null, null },
                    { 18L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6627), 4L, 1L, null, true, 0L, null, null, "حذف" },
                    { 19L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6632), 4L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 29L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 441, DateTimeKind.Local).AddTicks(2106), 3L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 21L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6650), 4L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 50L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 444, DateTimeKind.Local).AddTicks(5949), 7L, 1L, null, true, 0L, null, null, null },
                    { 49L, "GetGeneralParameterByID", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5723), 6L, 1L, null, true, 0L, null, null, null },
                    { 48L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5718), 6L, 1L, null, true, 0L, null, null, "حذف گروهی" }
                });

            migrationBuilder.InsertData(
                table: "ActionsEntities",
                columns: new[] { "Id", "ActionName", "AddedDate", "ControllerEntityID", "CreatedById", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "TitleEn", "TitleFr" },
                values: new object[,]
                {
                    { 47L, "Insert", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5714), 6L, 1L, null, true, 0L, null, null, "ایجاد" },
                    { 20L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6637), 4L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 45L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5707), 6L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 44L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5697), 6L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 43L, "GetParentCodes", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5582), 6L, 1L, null, true, 0L, null, null, "دریافت مقادیر پدر" },
                    { 42L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5578), 6L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 41L, "GetChildsByParents", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5571), 6L, 1L, null, true, 0L, null, null, "دریافت مقادیر پایه" },
                    { 40L, "GetAll", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5510), 6L, 1L, null, true, 0L, null, null, null },
                    { 46L, "GetGeneralParamsByCode", new DateTime(2021, 3, 20, 22, 43, 44, 443, DateTimeKind.Local).AddTicks(5710), 6L, 1L, null, true, 0L, null, null, "دریافت بر اساس کد" },
                    { 38L, "InsertWastage", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3767), 5L, 1L, null, true, 0L, null, null, null },
                    { 39L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3773), 5L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 22L, "PrintExcel", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6657), 4L, 1L, null, true, 0L, null, null, "دریافت گزارش اکسل" },
                    { 23L, "RemoveByIds", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6662), 4L, 1L, null, true, 0L, null, null, "حذف گروهی" },
                    { 32L, "InsertToStack", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3514), 5L, 1L, null, true, 0L, null, null, "اضافه کردن خروجی تکراری" },
                    { 24L, "RunJob", new DateTime(2021, 3, 20, 22, 43, 44, 439, DateTimeKind.Local).AddTicks(6667), 4L, 1L, null, true, 0L, null, null, null },
                    { 34L, "Remove", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3734), 5L, 1L, null, true, 0L, null, null, "حذف تکی" },
                    { 35L, "InsertToBalance", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3740), 5L, 1L, null, true, 0L, null, null, "ایجاد خروجی جدید" },
                    { 36L, "Edit", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3746), 5L, 1L, null, true, 0L, null, null, "ویرایش" },
                    { 37L, "Search", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3760), 5L, 1L, null, true, 0L, null, null, "جستجو" },
                    { 33L, "GetById", new DateTime(2021, 3, 20, 22, 43, 44, 442, DateTimeKind.Local).AddTicks(3724), 5L, 1L, null, true, 0L, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "GeneralParameters",
                columns: new[] { "Id", "AddedDate", "Code", "CreatedById", "Description", "IPAddress", "IsEnabled", "ModifiedById", "ModifiedDate", "ParentID", "Title" },
                values: new object[,]
                {
                    { 18L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4249), "00060002", 0L, null, null, true, 0L, null, 16L, "داخلی" },
                    { 9L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3850), "00030001", 0L, null, null, true, 0L, null, 8L, "ساعتی" },
                    { 17L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4243), "00060001", 0L, null, null, true, 0L, null, 16L, "حواله پیمانکار" },
                    { 12L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4071), "00040002", 0L, null, null, true, 0L, null, 10L, "غیر رسمی" },
                    { 11L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4063), "00040001", 0L, null, null, true, 0L, null, 10L, "رسمی" },
                    { 7L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3614), "00020002", 0L, null, null, true, 0L, null, 5L, "ثانویه" },
                    { 3L, new DateTime(2021, 3, 20, 22, 43, 44, 433, DateTimeKind.Local).AddTicks(6900), "00010002", 0L, null, null, true, 0L, null, 1L, "کیلوگرم" },
                    { 15L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3321), "00050002", 0L, null, null, true, 0L, null, 13L, "ماهیانه" },
                    { 14L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3215), "00050001", 0L, null, null, true, 0L, null, 13L, "ساعتی" },
                    { 4L, new DateTime(2021, 3, 20, 22, 43, 44, 433, DateTimeKind.Local).AddTicks(6905), "00010003", 0L, null, null, true, 0L, null, 1L, "تعداد" },
                    { 2L, new DateTime(2021, 3, 20, 22, 43, 44, 433, DateTimeKind.Local).AddTicks(6842), "00010001", 0L, null, null, true, 0L, null, 1L, "متر" },
                    { 21L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4385), "00070001", 0L, null, null, true, 0L, null, 20L, "خروجی تکراری" },
                    { 6L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(3607), "00020001", 0L, null, null, true, 0L, null, 5L, "اولیه" },
                    { 22L, new DateTime(2021, 3, 20, 22, 43, 44, 435, DateTimeKind.Local).AddTicks(4396), "00070002", 0L, null, null, true, 0L, null, 20L, "خروجی جدید" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionsEntities_ControllerEntityID",
                table: "ActionsEntities",
                column: "ControllerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionsRoleEntity_ActionsEntityID",
                table: "ActionsRoleEntity",
                column: "ActionsEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionsRoleEntity_RoleEntityID",
                table: "ActionsRoleEntity",
                column: "RoleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionsUserEntity_ActionsEntityID",
                table: "ActionsUserEntity",
                column: "ActionsEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionsUserEntity_UserEntityID",
                table: "ActionsUserEntity",
                column: "UserEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeerTypeFK_ID",
                table: "AspNetUsers",
                column: "EmployeerTypeFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SalaryTypeFK_ID",
                table: "AspNetUsers",
                column: "SalaryTypeFK_ID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerRoleEntities_ControllerEntityID",
                table: "ControllerRoleEntities",
                column: "ControllerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerRoleEntities_RoleEntityID",
                table: "ControllerRoleEntities",
                column: "RoleEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerUserEntity_ControllerEntityID",
                table: "ControllerUserEntity",
                column: "ControllerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_ControllerUserEntity_UserEntityID",
                table: "ControllerUserEntity",
                column: "UserEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CostEntity_CostCategoryID",
                table: "CostEntity",
                column: "CostCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CostJobEntities_JobEntityID",
                table: "CostJobEntities",
                column: "JobEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_FlowProcessEntities_processEntityID",
                table: "FlowProcessEntities",
                column: "processEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_flowProcessStockInitialEntities_FlowProcessEntityID",
                table: "flowProcessStockInitialEntities",
                column: "FlowProcessEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_flowProcessStockInitialEntities_stockRoom_InitialBalanceEntityID",
                table: "flowProcessStockInitialEntities",
                column: "stockRoom_InitialBalanceEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_FlowProcessUserSalaryEntities_FlowProcessEntityID",
                table: "FlowProcessUserSalaryEntities",
                column: "FlowProcessEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_FlowProcessUserSalaryEntities_processUserEntityID",
                table: "FlowProcessUserSalaryEntities",
                column: "processUserEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_FlowProcessUserSalaryEntities_UserID",
                table: "FlowProcessUserSalaryEntities",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralParameters_ParentID",
                table: "GeneralParameters",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceEntities_CategoryTypeFK_ID",
                table: "InitialBalanceEntities",
                column: "CategoryTypeFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceEntities_flowProcessEntityID",
                table: "InitialBalanceEntities",
                column: "flowProcessEntityID",
                unique: true,
                filter: "[flowProcessEntityID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceEntities_TypeMaterialFK_ID",
                table: "InitialBalanceEntities",
                column: "TypeMaterialFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceEntities_UnitMeaurementFK_ID",
                table: "InitialBalanceEntities",
                column: "UnitMeaurementFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceJobEntities_InitialBalanceEntityID",
                table: "InitialBalanceJobEntities",
                column: "InitialBalanceEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_InitialBalanceJobEntities_JobEntityID",
                table: "InitialBalanceJobEntities",
                column: "JobEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_LogEntities_UserID",
                table: "LogEntities",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_processBalanceEntities_InitialBalanceID",
                table: "processBalanceEntities",
                column: "InitialBalanceID");

            migrationBuilder.CreateIndex(
                name: "IX_processBalanceEntities_processEntityID",
                table: "processBalanceEntities",
                column: "processEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_processBalanceEntities_stockRoom_InitialBalanceID",
                table: "processBalanceEntities",
                column: "stockRoom_InitialBalanceID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessBalanceStockEntities_processBalanceEntityId",
                table: "ProcessBalanceStockEntities",
                column: "processBalanceEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessBalanceStockEntities_stockRoom_InitialBalanceEntityId",
                table: "ProcessBalanceStockEntities",
                column: "stockRoom_InitialBalanceEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_processEntities_ContractorTypeID",
                table: "processEntities",
                column: "ContractorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_processEntities_processDefinitionEntityID",
                table: "processEntities",
                column: "processDefinitionEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_processUserEntities_processEntityID",
                table: "processUserEntities",
                column: "processEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_processUserEntities_UserID",
                table: "processUserEntities",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoom_InitialBalances_InitialBalanceEntitiesFK_ID",
                table: "StockRoom_InitialBalances",
                column: "InitialBalanceEntitiesFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoom_InitialBalances_StockRoom_InitialBalanceFK_ID",
                table: "StockRoom_InitialBalances",
                column: "StockRoom_InitialBalanceFK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WastageEntity_FlowProcessEntityID",
                table: "WastageEntity",
                column: "FlowProcessEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_WastageEntity_InitialBalanceEntityID",
                table: "WastageEntity",
                column: "InitialBalanceEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionsRoleEntity");

            migrationBuilder.DropTable(
                name: "ActionsUserEntity");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ControllerRoleEntities");

            migrationBuilder.DropTable(
                name: "ControllerUserEntity");

            migrationBuilder.DropTable(
                name: "CostJobEntities");

            migrationBuilder.DropTable(
                name: "flowProcessStockInitialEntities");

            migrationBuilder.DropTable(
                name: "FlowProcessUserSalaryEntities");

            migrationBuilder.DropTable(
                name: "InitialBalanceJobEntities");

            migrationBuilder.DropTable(
                name: "LogEntities");

            migrationBuilder.DropTable(
                name: "ProcessBalanceStockEntities");

            migrationBuilder.DropTable(
                name: "tableInfoEntities");

            migrationBuilder.DropTable(
                name: "WastageEntity");

            migrationBuilder.DropTable(
                name: "ActionsEntities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CostEntity");

            migrationBuilder.DropTable(
                name: "processUserEntities");

            migrationBuilder.DropTable(
                name: "JobEntities");

            migrationBuilder.DropTable(
                name: "processBalanceEntities");

            migrationBuilder.DropTable(
                name: "ControllerEntities");

            migrationBuilder.DropTable(
                name: "CostCategoryEntity");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StockRoom_InitialBalances");

            migrationBuilder.DropTable(
                name: "InitialBalanceEntities");

            migrationBuilder.DropTable(
                name: "StockRoomEntities");

            migrationBuilder.DropTable(
                name: "FlowProcessEntities");

            migrationBuilder.DropTable(
                name: "processEntities");

            migrationBuilder.DropTable(
                name: "GeneralParameters");

            migrationBuilder.DropTable(
                name: "ProcessDefinitionEntities");
        }
    }
}
