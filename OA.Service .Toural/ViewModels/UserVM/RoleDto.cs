using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.UserVM
{
    public class RoleDto:BasePoco
    {
        public  Int64 Id { get; set; }
        public  string Name { get; set; }
        public bool IsEnabled { get; set; }
    }
}
