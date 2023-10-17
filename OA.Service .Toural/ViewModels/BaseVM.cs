using OA.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service_.Toural.ViewModels
{
    public class BaseVM
    {
        string _errorMessage;
        string _errorCode;
        public string Code { get; set; }
        public string ErrorMessage {
            get {
                if (hasError == false)
                    _errorMessage = ConstantsValue.successMessage;
                return _errorMessage;
            }
            set {
                _errorMessage = value;
            }
        }
        public List<string> ErrorMessages { get; set; }
        public bool hasError { get 
            {
                if (!string.IsNullOrEmpty(Code))
                {
                    if (Code == ConstantsValue.successCode)
                        return false;
                    return true;
                }
                return false;
            } 
        }
    }
}
