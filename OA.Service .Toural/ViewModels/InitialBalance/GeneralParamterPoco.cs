using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.InitialBalance
{
    public class GeneralParamterPoco: BasePoco
    {
        //public int Page
        //{
        //    get { return Page; }
        //    set
        //    {
        //        if (value == 0)
        //            value = 1;
        //    }
        //}
        //public int Row { get { return Row; } set { if (value == 0) value = 10; } }
        public string Sort { get; set; }
        public int Page { get; set; }
        public int Row { get; set; }
        public int ParentID { get; set; }
        public string ParentCode { get; set; }
        public long[] ids { get; set; }
    }
}
