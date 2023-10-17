using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.Cost
{
    public interface ICostService
    {
        CostVM Insert(CostDto body);
        CostVM Edit(CostDto Entity);
        CostVM GetAllCosts();
        CostVM GetAllCosts(DateTime StartMiladiDate,DateTime EndMiladiDate);
        CostVM GetAll();
        CostVM GetByID(long Id);
        CostVM Remove(long[] id);
        CostVM Remove(long id);
        CostVM Active(long id);
        CostVM Search(CostDto body);
        CostVM CalculateCostPerMonth();
        ExcelDto PrintExcel();
    }
}
