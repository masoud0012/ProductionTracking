using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class WastageSeed
    {
        public static int Seed(ModelBuilder modelBuilder, int id, Int64 parentID)
        {

            #region CostActions

            var costsActions = new List<ActionsEntity>();
            var costChild1 = new ActionsEntity()
            {
                Id = 217,
                ActionName = "SearchWastage",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "  مشاهده ضایعات",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = 218,
                ActionName = "PrintWastageExcel",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "دریافت اکسل ضایعات",
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
