using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OA.Common.Constants;
using OA.Common.EnumValues;
using OA.Common.Utility;
using OA.Data.Toural.ControllersEntity;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.UserEntity;
using OA.Data.UserEntity;
using OA.Repo.Troual.SeedEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo.Troual
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region unitMeasurment
            var parentUnitMeasurement = new GeneralParameter
            {
                Id = 1,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.UnitMeasurement),
                Title = "واحد اندازه گیری",
                IsEnabled = true
            };
            var child1 = new GeneralParameter
            {
                Id = 2,
                Title = "متر",
                Code = "00010001",
                ParentID = 1,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var child2 = new GeneralParameter
            {
                Id = 3,
                Title = "کیلوگرم",
                Code = "00010002",
                ParentID = 1,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var child3 = new GeneralParameter
            {
                Id = 4,
                Title = "تعداد",
                Code = "00010003",
                ParentID = 1,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(parentUnitMeasurement);
            modelBuilder.Entity<GeneralParameter>().HasData(child1);
            modelBuilder.Entity<GeneralParameter>().HasData(child2);
            modelBuilder.Entity<GeneralParameter>().HasData(child3);
            #endregion

            #region SalaryType
            var SalaryType = new GeneralParameter
            {
                Id = 13,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.SalaryType),
                Title = "حقوق و دستمزد",
                IsEnabled = true
            };
            var child9 = new GeneralParameter
            {
                Id = 14,
                Title = "ساعتی",
                Code = CommonUtility.GetSalaryType(SalaryTypeEnum.PerHour),
                ParentID = 13,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var child10 = new GeneralParameter
            {
                Id = 15,
                Title = "روزانه",
                Code = CommonUtility.GetSalaryType(SalaryTypeEnum.PerMonth),
                ParentID = 13,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(SalaryType);
            modelBuilder.Entity<GeneralParameter>().HasData(child9);
            modelBuilder.Entity<GeneralParameter>().HasData(child10);
            #endregion

            #region Category
            var materialType = new GeneralParameter
            {
                Id = 5,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.TypeMaterial),
                Title = "نوع موارد",
                IsEnabled = true
            };
            var materialTypeChild1 = new GeneralParameter
            {
                Id = 6,
                Title = "اولیه",
                Code = "00020001",
                ParentID = 5,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var materialTypeChild2 = new GeneralParameter
            {
                Id = 7,
                Title = "ثانویه",
                Code = "00020002",
                ParentID = 5,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(materialType);
            modelBuilder.Entity<GeneralParameter>().HasData(materialTypeChild1);
            modelBuilder.Entity<GeneralParameter>().HasData(materialTypeChild2);
            #endregion


            #region Category
            var Category = new GeneralParameter
            {
                Id = 8,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.Category),
                Title = "دسته بندی",
                IsEnabled = true
            };
            var categoryChild1 = new GeneralParameter
            {
                Id = 9,
                Title = "ساعتی",
                Code = "00030001",
                ParentID = 8,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(Category);
            modelBuilder.Entity<GeneralParameter>().HasData(categoryChild1);
            #endregion


            #region EmplooyerType
            var EmpoyerType = new GeneralParameter
            {
                Id = 10,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.EmplooyerType),
                Title = "نوع کارمند",
                IsEnabled = true
            };
            var emp1 = new GeneralParameter
            {
                Id = 11,
                Title = "رسمی",
                Code = "00040001",
                ParentID = 10,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var emp2 = new GeneralParameter
            {
                Id = 12,
                Title = "غیر رسمی",
                Code = "00040002",
                ParentID = 10,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(EmpoyerType);
            modelBuilder.Entity<GeneralParameter>().HasData(emp1);
            modelBuilder.Entity<GeneralParameter>().HasData(emp2);
            #endregion

            #region TypeProcess
            var typeProcess = new GeneralParameter
            {
                Id = 16,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.ProcessType),
                Title = "نوع انجام فرایند",
                IsEnabled = true
            };
            var Contractor = new GeneralParameter
            {
                Id = 17,
                Title = "حواله پیمانکار",
                Code = "00060001",
                ParentID = 16,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var Internal = new GeneralParameter
            {
                Id = 18,
                Title = "داخلی",
                Code = "00060002",
                ParentID = 16,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(typeProcess);
            modelBuilder.Entity<GeneralParameter>().HasData(Contractor);
            modelBuilder.Entity<GeneralParameter>().HasData(Internal);
            #endregion

            #region TypeFlowProcess
            var typeFlowProcess = new GeneralParameter
            {
                Id = 20,
                AddedDate = DateTime.Now,
                Code = CommonUtility.GetParentType(ParentEnum.FlowProcessType),
                Title = "نوع خروجی جریان فرایند",
                IsEnabled = true
            };
            var newFlowProcess = new GeneralParameter
            {
                Id = 21,
                Title = "خروجی تکراری",
                Code = "00070001",
                ParentID = 20,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            var hasFlowProcess = new GeneralParameter
            {
                Id = 22,
                Title = "خروجی جدید",
                Code = "00070002",
                ParentID = 20,
                AddedDate = DateTime.Now,
                IsEnabled = true
            };
            modelBuilder.Entity<GeneralParameter>().HasData(typeFlowProcess);
            modelBuilder.Entity<GeneralParameter>().HasData(newFlowProcess);
            modelBuilder.Entity<GeneralParameter>().HasData(hasFlowProcess);
            #endregion

            #region Controllers
            var AdminRoleController = new ControllerEntity()
            {
                Id =1,
                ControllerName = "AdminRole",
                TitleEn = "Role",
                IsEnabled = true,
                TitleFr = "مدیریت نقش ها"
            };
            var AdminUserController = new ControllerEntity()
            {
                Id = 2,
                ControllerName = "AdminUser",
                TitleEn = "User",
                IsEnabled = true,
                TitleFr = "مدیریت کاربران"
            };
            var CostCategoryController = new ControllerEntity()
            {
                Id = 3,
                ControllerName = "CostCategory",
                TitleEn = "CostCategory",
                IsEnabled = true,
                TitleFr = "مدیریت سرفصل هزینه ها"
            };
            var CostController = new ControllerEntity()
            {
                Id = 4,
                ControllerName = "Cost",
                TitleEn = "Cost",
                IsEnabled = true,
                TitleFr = "مدیریت هزینه ها"
            };
            var FlowProcessController = new ControllerEntity()
            {
                Id = 5,
                ControllerName = "FlowProcess",
                TitleEn = "FlowProcess",
                IsEnabled = true,
                TitleFr = "مدیریت خروجی فرایند"
            };
            var GeneralParameterController = new ControllerEntity()
            {
                Id = 6,
                ControllerName = "GeneralParamter",
                TitleEn = "GeneralParameter",
                IsEnabled=true,
                TitleFr = "دسته بندی"
            };
            var InitialBalanceController = new ControllerEntity()
            {
                Id = 7,
                ControllerName = "InitialBalance",
                TitleEn = "InitialBalance",
                IsEnabled = true,
                TitleFr = "مدیریت  مواد اولیه"
            };
            var ProcessBalanceController = new ControllerEntity()
            {
                Id = 8,
                ControllerName = "ProcessBalance",
                TitleEn = "ProcessBalance",
                IsEnabled = true,
                TitleFr = "مدیریت محصولات اولیه فرایند"
            };
            var ProcessController = new ControllerEntity()
            {
                Id = 9,
                ControllerName = "Process",
                TitleEn = "Process",
                IsEnabled = true,
                TitleFr = "مدیریت فرایند"
            };

            var ProcessDefinitionController = new ControllerEntity()
            {
                Id = 10,
                ControllerName = "ProcessDefinition",
                TitleEn = "Process Definition",
                IsEnabled = true,
                TitleFr = "مدیریت نوع فرایند"
            };
            var StockBalanceController = new ControllerEntity()
            {
                Id = 11,
                ControllerName = "StockBalance",
                TitleEn = "Stock Balance",
                IsEnabled = true,
                TitleFr = "مدیریت انبار خروجی فرایند"
            };

            var StockRoomController = new ControllerEntity()
            {
                Id = 12,
                ControllerName = "StockRoom",
                TitleEn = "Stock Room",
                IsEnabled = true,
                TitleFr = "مدیریت انبار"
            };

            var permissionController = new ControllerEntity()
            {
                Id = 14,
                ControllerName = "Controlls",
                TitleEn = "Permission User",
                IsEnabled = true,
                TitleFr = "مدیریت دسترسی کاربر"
            };

            var WasstageController = new ControllerEntity()
            {
                Id = 15,
                ControllerName = "Wasstage",
                TitleEn = "Wasstage",
                IsEnabled = true,
                TitleFr = "مدیریت ضایعات"
            };
            var UnitController = new ControllerEntity()
            {
                Id = 16,
                ControllerName = "UnitsParamter",
                TitleEn = "UnitsParamter",
                IsEnabled = true,
                TitleFr = "واحد اندازه گیری"
            };

            modelBuilder.Entity<ControllerEntity>().HasData(AdminRoleController);
            modelBuilder.Entity<ControllerEntity>().HasData(AdminUserController);
            modelBuilder.Entity<ControllerEntity>().HasData(CostCategoryController);
            modelBuilder.Entity<ControllerEntity>().HasData(CostController);
            modelBuilder.Entity<ControllerEntity>().HasData(FlowProcessController);
            modelBuilder.Entity<ControllerEntity>().HasData(GeneralParameterController);
            modelBuilder.Entity<ControllerEntity>().HasData(InitialBalanceController);
            modelBuilder.Entity<ControllerEntity>().HasData(ProcessBalanceController);
            modelBuilder.Entity<ControllerEntity>().HasData(ProcessController);
            modelBuilder.Entity<ControllerEntity>().HasData(ProcessDefinitionController);
            modelBuilder.Entity<ControllerEntity>().HasData(StockBalanceController);
            modelBuilder.Entity<ControllerEntity>().HasData(StockRoomController);
            modelBuilder.Entity<ControllerEntity>().HasData(permissionController);
            modelBuilder.Entity<ControllerEntity>().HasData(WasstageController);
            #endregion
            int id = 1;
            id = AdminUserSeed.Seed(modelBuilder, id, AdminUserController.Id);
            id = AdminRoleSeed.Seed(modelBuilder, id, AdminRoleController.Id);
            id = CostSeed.Seed(modelBuilder, id,CostController.Id);
            id = CostCategorySeed.Seed(modelBuilder,id,CostCategoryController.Id);
            id =FlowProcessSeed.Seed(modelBuilder, id,FlowProcessController.Id);
            id =GeneralParamterSeed.Seed(modelBuilder, id, GeneralParameterController.Id);
            id =InitialBalanceSeed.Seed(modelBuilder, id, InitialBalanceController.Id);
            id =ProcessBalanceSeed.Seed(modelBuilder, id, ProcessBalanceController.Id);
            id =ProcessSeed.Seed(modelBuilder, id, ProcessController.Id);
            id =ProcessDefinitionSeed.Seed(modelBuilder, id, ProcessDefinitionController.Id);
            id = StockRoomSeed.Seed(modelBuilder, id, StockRoomController.Id);
            id =StockBalanceSeed.Seed(modelBuilder, id, StockBalanceController.Id);
            id = ControlsSeed.Seed(modelBuilder, id, permissionController.Id);
            id = WastageSeed.Seed(modelBuilder, id, WasstageController.Id);
            id = UnitsSeed.Seed(modelBuilder, id, UnitController.Id);
        }

        public static void SeedData(UserManager<User> userManager, RoleManager<RoleEntity> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
            
        }

        public static void SeedUsers(UserManager<User> userManager)
        {
            try
            {
                if (userManager.FindByNameAsync("Admin").Result == null)
                {
                    User user = new User();
                    user.UserName = "Admin";
                    user.LastName = "سامانه";
                    user.FirstName = "ادمین";
                    IdentityResult result = userManager.CreateAsync
                    (user, "123456").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user,
                                            ConstantsValue.AdminRole).Wait();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static void SeedRoles(RoleManager<RoleEntity> roleManager)
        {
            try
            {
                if (!roleManager.RoleExistsAsync(ConstantsValue.AdminRole).Result)
                {
                    RoleEntity role = new RoleEntity();
                    role.Name = ConstantsValue.AdminRole;
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                }
                if (!roleManager.RoleExistsAsync(ConstantsValue.NormalRole).Result)
                {
                    RoleEntity role = new RoleEntity();
                    role.Name = ConstantsValue.NormalRole;
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                }
            }
            catch (Exception ex)
            {

                
            }
        }
    }


}
