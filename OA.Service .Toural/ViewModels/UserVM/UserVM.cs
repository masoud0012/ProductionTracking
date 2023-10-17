using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels.UserVM
{
    public class UserVM:BaseVM
    {
        public UserDto userDto { get; set; }
        public List<UserDto> userDtos { get; set; }
        public int numberRows { get;  set; }
    }
}
