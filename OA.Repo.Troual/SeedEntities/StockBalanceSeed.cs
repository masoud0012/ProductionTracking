using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class StockBalanceSeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 parentID)
        {
            var costsActions = new List<ActionsEntity>();
    
            var costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Get",
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
                ActionName = "Insert",
                TitleFr = "ایجاد",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            modelBuilder.Entity<ActionsEntity>().HasData(costsActions);
            return id;
        }
    }
}
