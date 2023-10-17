using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.DashboardVM
{
    public class DashboardVM:BaseVM
    {
        public Process.ProcessDto ProcessDto { get; set; }
        public FlowProcess.FlowProcessDto FlowProcessDto { get; set; }
        public InitialBalance.InitialBalancePoco InitialBalanceDto { get; set; }
        public StockRoom.StockRoomDto StockRoomDto { get; set; }
        public Cost.CostDto CostDto { get; set; }
        public Cost.CostCategoryDto CostCategoryDto { get; set; }

        public List<InitialBalance.InitialBalancePoco> InitialBalanceDtos { get; set; }

        public List<StockRoom.StockRoomDto> StockRoomDtos { get; set; }
        public DashboardDto dashboardDto { get; set; }
        public List<LogDto> LogDtos { get; set; }
        public int numberRows { get; set; }
    }
}
