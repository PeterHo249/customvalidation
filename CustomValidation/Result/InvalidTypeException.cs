using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class InvalidTypeException : ValidateException
    {
        public InvalidTypeException()
        {
            _message = "Candidate is invalid type.";
            _code = ExceptionType.INVALID_TYPE;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
