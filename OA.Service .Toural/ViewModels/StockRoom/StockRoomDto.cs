using OA.Service_.Toural.ViewModels.DashboardVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.StockRoom
{
    public class StockRoomDto:BasePoco
    {
        public long[] ids { get; set; }
        public string Address { get; set; }
        public string Sort { get; set; }
        public int Page { get; set; }
        //public int Row { get { return Row; } set { if (value == 0) value = 10; } }
        public int Row { get; set; }
        public int CountRows { get; set; }
        public DashboardDto DashboardDto { get; set; }

    }
}
