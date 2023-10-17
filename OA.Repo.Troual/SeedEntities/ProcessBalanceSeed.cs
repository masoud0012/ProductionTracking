using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class ProcessBalanceSeed
    {
        public static int Seed(ModelBuilder modelBuilder,int id,Int64 ParentID)
        {
            var costsActions = new List<ActionsEntity>();
    
            var costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "Edit",
                ControllerEntityID = ParentID,
                TitleFr = "ویرایش",
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
                ControllerEntityID = ParentID,
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
