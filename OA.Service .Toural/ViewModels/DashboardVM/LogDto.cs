using System;

namespace OA.Service_.Toural.ViewModels.DashboardVM
{
    public class LogDto
    {
        public string OperationTitle { get; set; }
        public Int64 ID { get; set; }
        public string Description { get; set; }
        public bool IsCreated { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
