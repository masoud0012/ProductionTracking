using OA.Data.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Toural.TableInfo
{
    public  class TableInfoEntity:BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string LastInsertedCode { get; set; }

    }
}
