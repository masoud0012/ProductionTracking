using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Common.Exceptions
{
    public  class CustomErrorException : Exception
    {
        public string errorMessage { get; set; }
        public List<string> errorMessages { get; set; }
        public string Code { get; set; }
        public CustomErrorException(string Message, string Code, List<string> errorMessages=null)
        {
            errorMessage = Message;
            this.Code = Code;
            this.errorMessages = errorMessages;
        }
    }
}
