using Microsoft.Extensions.DependencyInjection;
using OA.Repo.Troual;
using OA.Repo.Troual.Contracts.Job;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.Contracts.JobService;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.JobService
{
    [DisallowConcurrentExecution]
    public class CostJobService : IJob
    {
        private readonly IServiceProvider _provider;

        public CostJobService(IServiceProvider provider)
        {
            _provider = provider;
        }
        public Task Execute(IJobExecutionContext context)
        {

            using (var scope = _provider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<TouralContext>();
                var costService = scope.ServiceProvider.GetService<ICostService>();
                costService.CalculateCostPerMonth();
            }

            return Task.CompletedTask;
        }
    }
}
