using OA.Service_.Toural.ViewModels.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.Cost
{
    public interface ICostCategoryService
    {
        CostVM Insert(CostCategoryDto body);
        CostVM Edit(CostCategoryDto Entity);
        CostVM GetAll();
        CostVM GetByID(long Id);
        CostVM Remove(long[] id);
        CostVM Remove(long id);
        CostVM Active(long id);
        CostVM Search(CostCategoryDto body);
        void SaveChanges();
    }
}
