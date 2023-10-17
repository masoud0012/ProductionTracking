using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class AdminUserSeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 parentID)
        {
            var costsActions = new List<ActionsEntity>();
    
            var costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetById",
                ControllerEntityID = parentID,
                IsEnabled = true,
                
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Remove",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                TitleFr = "حذف تکی",
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Edit",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "ویرایش",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetUsers",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "مشاهده همه کاربران",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Insert",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "ایجاد کردن",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Active",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "RemoveByIds",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "حذف گروهی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "ChangePassword",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "تغییر پسورد",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Login",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Search",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "جستجو",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            modelBuilder.Entity<ActionsEntity>().HasData(costsActions);
            return id;
        }
    }
}
