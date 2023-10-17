using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public class ActionsEntity:BaseEntities.BaseEntity
    {
        public String TitleFr { get; set; }
        public String TitleEn { get; set; }
        public string ActionName { get; set; }
        public Int64 ControllerEntityID { get; set; }
        public ControllerEntity ControllerEntity { get; set; }
        public List<ActionsRoleEntity> ActionsRoleEntities { get; set; }
        public List<ActionsUserEntity> ActionsUserEntities { get; set; }
    }
}
