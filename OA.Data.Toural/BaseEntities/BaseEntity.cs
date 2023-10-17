using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Data.BaseEntities
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Int64 CreatedById { get; set; }
        public Int64 ModifiedById { get; set; }
        public string IPAddress { get; set; }

        public bool IsEnabled { get; set; }

    }
}
