using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OA.Common.Constants;
using OA.Data.BaseEntities;
using OA.Data.Toural.ControllersEntity;
using OA.Data.Toural.Cost;
using OA.Data.Toural.CostConfiguration;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Job;
using OA.Data.Toural.LogEntity;
using OA.Data.Toural.Process;
using OA.Data.Toural.StockRoom;
using OA.Data.Toural.TableInfo;
using OA.Data.Toural.UserEntity;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repo.Troual
{
    public class TouralContext : IdentityDbContext<User, IdentityRole<Int64>, Int64>
    {
        private IServiceProvider serviceProvider;
        public TouralContext(DbContextOptions options, IServiceProvider serviceProvider) : base(options)
        {
            this.serviceProvider = serviceProvider;
        }
        public DbSet<GeneralParameter> GeneralParameters { get; set; }
        public DbSet<InitialBalanceEntity> InitialBalanceEntities { get; set; }
        public DbSet<StockRoom_InitialBalanceEntity> StockRoom_InitialBalances { get; set; }
        public DbSet<TableInfoEntity> tableInfoEntities { get; set; }
        public DbSet<StockRoomEntity> StockRoomEntities { get; set; }
        public DbSet<ProcessEntity> processEntities { get; set; }
        public DbSet<ProcessBalanceEntity> processBalanceEntities { get; set; }
        public DbSet<ProcessBalanceStockEntity> ProcessBalanceStockEntities { get; set; }
        public DbSet<ProcessUserEntity> processUserEntities { get; set; }
        public DbSet<FlowProcessEntity> FlowProcessEntities { get; set; }
        public DbSet<FlowProcessStockInitialEntity> flowProcessStockInitialEntities { get; set; }
        public DbSet<FlowProcessUserSalaryEntity> FlowProcessUserSalaryEntities { get; set; }

        public DbSet<ProcessDefinitionEntity> ProcessDefinitionEntities { get; set; }
        public DbSet<ControllerRoleEntity> ControllerRoleEntities { get; set; }
        public DbSet<ActionsEntity> ActionsEntities { get; set; }
        public DbSet<ControllerEntity> ControllerEntities { get; set; }
        public DbSet<CostJobEntity> CostJobEntities { get; set; }
        public DbSet<InitialBalanceJobEntity> InitialBalanceJobEntities { get; set; }
        public DbSet<JobEntities> JobEntities { get; set; }
        public DbSet<LogEntity> LogEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new InitialBalanceConfig());
            modelBuilder.ApplyConfiguration(new GeneralParameterConfig());
            modelBuilder.ApplyConfiguration(new StockRoomConfig());
            modelBuilder.ApplyConfiguration(new StockRoom_InitialBalanceConfig());
            modelBuilder.ApplyConfiguration(new RoleEntityMap());
            modelBuilder.ApplyConfiguration(new CostCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CostEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CostJobEntityConfig());
            modelBuilder.ApplyConfiguration(new JobEntitiesConfig());
            modelBuilder.ApplyConfiguration(new InitialBalanceJobEntityConfig());
            modelBuilder.ApplyConfiguration(new ControllerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ActionEntityConfiguration());
            modelBuilder.Seed();

            //RoleEntity role = new RoleEntity();
            //role.Name = ConstantsValue.AdminRole;
            //modelBuilder.Entity<IdentityRole>().HasData(role);
            //RoleEntity newNormalrole = new RoleEntity();
            //newNormalrole.Name = ConstantsValue.NormalRole;
            //modelBuilder.Entity<IdentityRole>().HasData(role);
            //User user = new User();
            //user.UserName = "Admin";
            //user.LastName = "سامانه";
            //user.FirstName = "ادمین";
            //modelBuilder.Entity<User>().HasData(user);

            //var identityUserRole = new Microsoft.AspNetCore.Identity.IdentityUserRole<long>();
            //identityUserRole.UserId = user.Id;
            //identityUserRole.RoleId = role.Id;
            //modelBuilder.Entity<IdentityUserRole<long>>().HasData(identityUserRole);

        }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
            .Where(t => t.State == EntityState.Added)
            .Select(t => t.Entity)
            .ToArray();

            var modified = this.ChangeTracker.Entries()
            .Where(t => t.State == EntityState.Modified)
            .Select(t => t.Entity)
            .ToArray();
            var Controllers = ControllerEntities.Where(z => z.IsEnabled == true).Include(z => z.ActionsEntities).ToList();
            foreach (var item in added)
            {
                var entity = item as BaseEntity;
                if (entity != null)
                {

                    var ControllerItem = GetControllerEntityByEntity(entity, Controllers);
                    if (ControllerItem != null)
                    {
                        LogEntities.Add(new LogEntity
                        {
                            Title = entity.GetType().GetProperty("Title") != null ? entity.GetType().GetProperty("Title").GetValue(entity, null).ToString() : string.Empty,
                            OperationTitle = ControllerItem.TitleFr,
                            CreatedDate = DateTime.Now,
                            IsCreated = true,
                            UserID = entity.CreatedById,
                        });
                    }
                }
            }

            foreach (var item in modified)
            {
                var entity = item as BaseEntity;
                if (entity != null)
                {
                    var ControllerItem = GetControllerEntityByEntity(entity, Controllers);
                    if (ControllerItem != null)
                    {
                        LogEntities.Add(new LogEntity
                        {
                            Title = entity.GetType().GetProperty("Title") != null ? entity.GetType().GetProperty("Title").GetValue(entity, null).ToString() : string.Empty,
                            OperationTitle = ControllerItem.TitleFr,
                            CreatedDate = DateTime.Now,
                            IsCreated = false,
                            UserID = entity.CreatedById,
                        });
                    }
                }


            }

            return base.SaveChanges();
        }

        private ControllerEntity GetControllerEntityByEntity(BaseEntity entity, List<ControllerEntity> ControllerEntities)
        {

            if (entity.GetType() == typeof(StockRoomEntity))
            {
                return ControllerEntities.Where(z => z.Id == 12).FirstOrDefault();
            }
            else if (entity.GetType() == typeof(InitialBalanceEntity))
            {
                return ControllerEntities.Where(z => z.Id == 7).FirstOrDefault();
            }
            else if (entity.GetType() == typeof(CostCategoryEntity))
            {
                return ControllerEntities.Where(z => z.Id == 3).FirstOrDefault();
            }
            else if (entity.GetType() == typeof(CostEntity))
            {
                return ControllerEntities.Where(z => z.Id == 4).FirstOrDefault();
            }
            else if (entity.GetType() == typeof(User))
            {
                return ControllerEntities.Where(z => z.Id == 2).FirstOrDefault();
            }
            else if (entity.GetType() == typeof(FlowProcessEntity))
            {
                return ControllerEntities.Where(z => z.Id == 5).FirstOrDefault();
            }
            if (entity.GetType() == typeof(ProcessEntity))
            {
                return ControllerEntities.Where(z => z.Id == 9).FirstOrDefault();
            }
            if (entity.GetType() == typeof(ProcessDefinitionEntity))
            {
                return ControllerEntities.Where(z => z.Id == 10).FirstOrDefault();
            }
            if (entity.GetType() == typeof(GeneralParameter))
            {
                return ControllerEntities.Where(z => z.Id == 6).FirstOrDefault();
            }

            return null;
        }

    }
}
