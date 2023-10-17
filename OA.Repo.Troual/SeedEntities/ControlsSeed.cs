using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class ControlsSeed
    {
        public static int Seed(ModelBuilder modelBuilder, int id, Int64 parentID)
        {
            #region CostCategoryActions
            var CostCategory = new List<ActionsEntity>();
            var categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetControls",
                ControllerEntityID = parentID,
                TitleFr="مشاهده صفحه دسترسی",
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetActions",
                TitleFr ="مشاهده عملیات",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetControlsUserGrants",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "مشاهده دسترسی داده شده عملیات",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "GetActionsUserGrants",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "مشاهده دسترسی داده شده",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            CostCategory.Add(categoryChild1);
            categoryChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "SetGrantToUser",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "اعمال دسترسی",
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
