using OA.Service_.Toural.ViewModels.DashboardVM;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.FlowProcess
{
    public class FlowProcessDto:BasePoco
    {
        public int Page { get; set; }
        public int Row { get; set; }
        public long[] ids { get; set; }
        public string Sort { get; set; }
        public Int64 processID { get; set; }
        public string TotalPrice { get; set; }

        public int SumLaborer { get; set; }
        public int SumHours { get; set; }
        public string FinalCost { get; set; }
        public Int64 TotalSalaryPayment { get; set; }
        public bool IsNewMaterial { get; set; }

        public int IsForeignWorker { get; set; }
        public string Hire { get; set; }

        public Int64 InitialBalanceID { get; set; }
        public Int64 StockRoomID { get; set; }
        public Int64 Count { get; set; }
        public string Replace { get; set; }

        public List<StockRoom_InitialBalanceDto> StockRoom_InitialBalanceDtos { get; set; }

        public InitialBalancePoco initialBalanceDto { get; set; }

        public List<InitialBalancePoco> wastagesDto { get; set; }
        public List<FlowProcessUserSalaryModel> UserSalaryDtos { get; set; }
        public Process.ProcessDto ProcessDto { get; set; }
        public DashboardDto DashboardDto { get; set; }
    }
}
