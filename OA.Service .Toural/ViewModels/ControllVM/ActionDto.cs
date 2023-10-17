using System;

namespace OA.Service_.Toural.ViewModels.ControllVM
{
    public class ActionDto : BasePoco
    {
        public String TitleFr { get; set; }
        public String TitleEn { get; set; }
        public string ActionName { get; set; }
        public Int64 ControllerID { get; set; }
        public string ControllerName { get; set; }
        public Int64 UserID { get; set; }
        public Int64[] ActionIDs { get; set; }
    }
}
