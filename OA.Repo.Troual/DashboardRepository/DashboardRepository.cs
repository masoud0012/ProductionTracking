using Microsoft.EntityFrameworkCore;
using OA.Repo.Troual.Contracts.DashboardRepository;
using OA.Repo.Troual.FlowProcessRepsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo.Troual.DashboardRepository
{
    public class DashboardRepository: IDashboardRepository
    {
        private readonly TouralContext context;
        private DbSet<FlowProcessRepository> entities;
        public DashboardRepository(TouralContext context)
        {
            this.context = context;
            entities = context.Set<FlowProcessRepository>();
        }

    }
}
