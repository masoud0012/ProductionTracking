using OA.Data.Toural.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public  class ControllerRoleEntity:BaseEntities.BaseEntity
    {
        public Int64 ControllerEntityID { get; set; }
        public ControllerEntity ControllerEntity { get; set; }

        public Int64 RoleEntityID { get; set; }
        public RoleEntity RoleEntity { get; set; }
    }
}
