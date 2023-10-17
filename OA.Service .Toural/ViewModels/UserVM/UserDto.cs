using OA.Service_.Toural.ViewModels.ControllVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.UserVM
{
    public class UserDto:BasePoco
    {
        public int Page { get; set; }
        public int Row { get; set; }
        public string Sort { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public long[] ids { get; set; }
        public Int64 SalaryPerHour { get; set; }
        public Int64 SalaryPerMonth { get; set; }
        public Int64 SalaryPayment { get; set; }
        public Int64 MaxWorkPerHour { get; set; }
        public Int64 MaxWorkPerDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string password { get; set; }
        public string Mobile { get; set; }
        public decimal Duration { get; set; }
        public Int64 SalaryTypeFK_ID { get; set; }
        public Int64 EmployeerTypeFK_ID { get; set; }
        public List<ControllerDto> ControllerDtos { get; set; }
        public List<ActionDto> ActionDtos { get; set; }

    }
}
