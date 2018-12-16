using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotEqualException : ValidateException
    {
        public NotEqualException()
        {
            _message = "Candidate is not equal.";
            _code = ExceptionType.NOT_EQUAL;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
