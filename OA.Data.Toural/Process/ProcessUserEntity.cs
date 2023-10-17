using OA.Data.BaseEntities;
using OA.Data.Toural.FlowProcess;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.Process
{
    public  class ProcessUserEntity:BaseEntity
    {
        public Int64? UserID { get; set; }
        public User user { get; set; }

        public Int64? processEntityID { get; set; }
        public ProcessEntity processEntity { get; set; }

        public List<FlowProcessUserSalaryEntity> flowProcessUserSalaryEntities { get; set; }
    }
}
