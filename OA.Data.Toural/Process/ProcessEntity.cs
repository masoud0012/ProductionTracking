using OA.Data.BaseEntities;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.InitialBalance;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public class ProcessEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ContractorName { get; set; }

        public Int64? ContractorTypeID { get; set; }
        public GeneralParameter ContractorType { get; set; }
        public string ContractorFullName { get; set; }

        public List<ProcessUserEntity> UserContractors { get; set; }

        public decimal TotalPrice { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool IsFinalStep { get; set; }
        public List<ProcessBalanceEntity> processBalanceEntities { get; set; }

        public List<FlowProcessEntity> flowProcessEntities { get; set; }

        public Int64 processDefinitionEntityID { get; set; }
        public ProcessDefinitionEntity processDefinitionEntity { get; set; }

        


    }
}
