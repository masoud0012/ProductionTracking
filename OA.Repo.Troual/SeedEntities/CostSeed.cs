using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class CostSeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 parentID)
        {

            #region CostActions

            var costsActions = new List<ActionsEntity>();
    
            var costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetAll",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
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
                TitleFr = "حذف",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Insert",
                ControllerEntityID = parentID,
                TitleFr = "ایجاد",
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Edit",
                TitleFr = "ویرایش",
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
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "PrintExcel",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "دریافت گزارش اکسل",
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
                ActionName = "RunJob",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);

            modelBuilder.Entity<ActionsEntity>().HasData(costsActions);
            #endregion
            return id;
        }
    }
}
