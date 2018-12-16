using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class CustomException : ValidateException
    {
        public CustomException()
        {
            _message = "Candidate is invalid.";
            _code = ExceptionType.CUSTOM;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
