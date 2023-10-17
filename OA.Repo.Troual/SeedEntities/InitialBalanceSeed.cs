using Microsoft.EntityFrameworkCore;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.SeedEntities
{
    public static class InitialBalanceSeed
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
                ActionName = "EditBalanceStock",
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
                ActionName = "GetBalanceByID",
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
                ActionName = "GetQuantityStock",
                ControllerEntityID = parentID,
                TitleFr="دریافت  ظرفیت انبار",
                IsEnabled = true,
                CreatedById = 1,
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
                ActionName = "Search",
                ControllerEntityID = parentID,
                TitleFr = "جستجو",
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "SearchAutoComplete",
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
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "ایجاد",
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
                ActionName = "SearchAutoCompleteExceptIds",
                ControllerEntityID = parentID,
                IsEnabled = true,
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = id++,
                ActionName = "SearchFinalProducts",
                ControllerEntityID = parentID,
                TitleFr = "جستجو محصولات نهایی",
                IsEnabled = true,
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
                TitleFr = "دریافت  اکسل محصولات نهایی",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = 213,
                ActionName = "GetWastage",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "مشاهده لیست ضایعات",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = 214,
                ActionName = "PrintWastage",
                ControllerEntityID = parentID,
                IsEnabled = true,
                TitleFr = "دریافت فایل اکسل ضایعات",
                CreatedById = 1,
                AddedDate = DateTime.Now
            };
            costsActions.Add(costChild1);
            costChild1 = new ActionsEntity()
            {
                Id = 215,
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
                Id = 216,
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
