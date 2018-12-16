using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotLessOrEqualException : ValidateException
    {
        public NotLessOrEqualException()
        {
            _message = "Candidate is not less or equal.";
            _code = ExceptionType.NOT_LESS_OR_EQUAL;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
