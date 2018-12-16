using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotGreaterOrEqualException : ValidateException
    {
        public NotGreaterOrEqualException()
        {
            _message = "Candidate is not greater or equal";
            _code = ExceptionType.NOT_GREATER_OR_EQUAL;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
