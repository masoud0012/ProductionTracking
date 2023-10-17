using OA.Data.BaseEntities;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.ControllersEntity
{
    public  class ActionsUserEntity:BaseEntity
    {
        public Int64 ActionsEntityID { get; set; }
        public ActionsEntity ActionsEntity { get; set; }

        public Int64 UserEntityID { get; set; }
        public User UserEntity { get; set; }
    }
}
