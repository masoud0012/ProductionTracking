using OA.Data.BaseEntities;
using OA.Data.Toural.InitialBalance;
using OA.Data.Toural.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.FlowProcess
{
    public class FlowProcessEntity: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Int64? processEntityID { get; set; }
        public ProcessEntity processEntity { get; set; }


        public int SumLaborer { get; set; }
        public int SumHours { get; set; }
        public string TotalPrice { get; set; }

        public bool IsNewMaterial { get; set; }
        
        public int IsForeignWorker { get; set; }
        public string Hire { get; set; }

        public string FinalCost { get; set; }//قیمت تمام شده

        public List<FlowProcessUserSalaryEntity> flowProcessUserSalaryEntities { get; set; }

        public List<WastageEntity> wastageEntities { get; set; }

        public InitialBalanceEntity InitialBalanceEntity { get; set; }
        public List<FlowProcessStockInitialEntity> flowPorcessStockInitialEntities { get; set; }
    }


}
