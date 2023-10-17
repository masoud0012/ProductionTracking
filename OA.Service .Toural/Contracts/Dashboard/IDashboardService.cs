using OA.Service_.Toural.ViewModels.DashboardVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts
{
    public interface IDashboardService
    {
        DashboardVM GetLastActivity(Int64 UserID);
        DashboardVM GetLastInitialBalance(Int64 UserID);

        DashboardVM GetLastStockActivity(Int64 UserID);
        DashboardVM GetProcessChart();
        DashboardVM GetCostChart();

        DashboardVM GetLogEntities(DashboardDto body);



    }
}
