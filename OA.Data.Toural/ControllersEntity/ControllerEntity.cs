using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public class ControllerEntity:BaseEntities.BaseEntity
    {
        public String ControllerName { get; set; }
        public String TitleEn { get; set; }
        public String TitleFr { get; set; }
        public List<ActionsEntity> ActionsEntities { get; set; }
        public List<ControllerRoleEntity> ControllerRoleEntities { get; set; }

        public List<ControllerUserEntity> ControllerUserEntities { get; set; }
    }
}
