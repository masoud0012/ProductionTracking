using OA.Data.Toural.ControllersEntity;
using OA.Data.UserEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.LogEntity
{
    public class LogEntity
    {
        public string Title { get; set; }
        public string OperationTitle { get; set; }
        public Int64 ID { get; set; }
        public string Description { get; set;    }
        public Int64 UserID { get; set; }
        public User User { get; set; }
        public bool IsCreated { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
