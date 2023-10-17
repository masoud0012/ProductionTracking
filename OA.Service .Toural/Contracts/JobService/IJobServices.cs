using OA.Data.Toural.Cost;
using OA.Service_.Toural.ViewModels.Cost;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.JobService
{
    public  interface IJobServices
    {
        void SaveJob(List<CostEntity> costEntities, List<InitialBalancePoco> initialBalanceDtos, Decimal WeightInCalculation);
        ExcelDto GetJob(string ID);
        JobVM GetJobs();
        JobVM GetPrevMonthJob(DateTime startMiladiDate, DateTime endMiladiDate);
        decimal? GetPrevMonthJob(DateTime startMiladiDate, DateTime endMiladiDate, long currentMonthCost,long totalPriceBalanceCurrentMonth);
    }
}
