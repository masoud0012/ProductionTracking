using OA.Data.BaseEntities;
using OA.Data.Toural.FlowProcess;
using OA.Data.Toural.Process;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data.Toural.InitialBalance
{
    public class GeneralParameter:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Int64? ParentID { get; set; }
        public string Code { get; set; }
        public GeneralParameter Parent { get; set; }
        public List<GeneralParameter> Children { get; set; }
        public List<InitialBalanceEntity> InitialBalance_UnitMeasurement { get; set; }
        public List<InitialBalanceEntity> InitialBalance_TypeMaterial { get; set; }
        public List<InitialBalanceEntity> InitialBalance_CategoryTypes { get; set; }

        public List<User> Emplooyers { get; set; }

        public List<User> Emplooyers_Salary { get; set; }

        public List<ProcessEntity> Contractors { get; set; }
        public List<WastageEntity> wastageEntities { get; set; }
    }
}
