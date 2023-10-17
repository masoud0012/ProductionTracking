using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class UnitsSeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 parentID)
        {

            #region CostActions

            var costsActions = new List<ActionsEntity>();
            var costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "EditUnits",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                TitleFr = "ویرایش",
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "SearchUnits",
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
                ActionName = "RemoveUnits",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "حدف تکی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "RemoveByIdsUnits",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "حدف گروهی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "InsertUnits",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "افزودن",
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
