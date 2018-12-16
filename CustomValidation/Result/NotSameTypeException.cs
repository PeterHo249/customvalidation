using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotSameTypeException : ValidateException
    {
        public NotSameTypeException()
        {
            _message = "Candidate is not same type.";
            _code = ExceptionType.NOT_SAME_TYPE;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
