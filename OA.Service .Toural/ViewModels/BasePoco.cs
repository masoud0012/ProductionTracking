using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels
{
    public  class BasePoco
    {
        public Int64 ID { get; set; }
        public int IsEnabled { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string createdDate { get; set; }
        public string modifiedDate { get; set; }
        public string Token { get; set; }
        public bool IsModified { get; set; }
        public bool IsModifedNew { get; set; }
    }
}
