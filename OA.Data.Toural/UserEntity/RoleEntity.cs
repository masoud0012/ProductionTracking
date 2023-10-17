using Microsoft.AspNetCore.Identity;
using OA.Data.Toural.ControllersEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Data.Toural.UserEntity
{
    public class RoleEntity:IdentityRole<Int64>
    {
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsEnabled { get; set; }
        public List<ControllerRoleEntity> ControllerRoleEntities { get; set; }
        public List<ActionsRoleEntity>  ActionsRoleEntities { get; set; }
    }
}
