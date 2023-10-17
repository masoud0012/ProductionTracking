using OA.Service_.Toural.ViewModels.DashboardVM;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Process
{
    public class ProcessDto : BasePoco
    {
        public string Sort { get; set; }
        public int Row { get; set; }
        public int Page { get; set; }
        public long[] ids { get; set; }
        public Int64 ProcessDefinitionID { get; set; }
        public string ProcessDefinitionTitle { get; set; }
        public string ContractorName { get; set; }
        public Int64 ProcessBalanceID { get; set; }
        public Int64? ContractorTypeID { get; set; }
        public string ContractorTypeName { get; set; }
        public string ContractorFullName { get; set; }
        public Int64[] UserContractorID { get; set; }

        public string TotalPrice { get; set; }
        public string IssueDate { get; set; }
        public string IssueDatePersian { get; set; }

        public bool IsFinalStep { get; set; }
        public int DaysInMonth { get; set; }
        public string Status { get; set; }
        public List<ProcessBalanceDto> processBalanceDtos { get; set; }

        public DashboardDto DashboardDto { get; set; }

        //public List<ProcessBalanceEntity> processBalanceEntities { get; set; }
        //public List<FlowProcessEntity> flowProcessEntities { get; set; }
    }
}
