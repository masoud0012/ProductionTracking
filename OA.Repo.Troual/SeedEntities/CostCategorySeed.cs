using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using OA.Data.Toural.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static  class CostCategorySeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 parentID)
        {
            #region CostCategoryActions
            var CostCategory = new List<ActionsEntity>();
            var categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetAll",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetById",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Remove",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "حذف تکی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Insert",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "ایجاد",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Edit",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "ویرایش",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Search",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                TitleFr = "جستجو",
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "RemoveByIds",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "حذف گروهی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);

            #endregion
            modelBuilder.Entity<ActionsEntity>().HasData(CostCategory);

            return id;
        }
    }
}
