using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Process
{
    public  class ProcessBalanceDto:BasePoco
    {
        public List<StockRoom_InitialBalanceDto> stockRoom_InitialBalanceDtos { get; set; }
        public Int64 InitialBalanceID { get; set; }

        public Int64? stockRoom_InitialBalanceID { get; set; }
        public Int64 processEntityID { get; set; }

        public Int64 Count { get; set; }

        public string TotalPrice { get; set; }
    }
}
