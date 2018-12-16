using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotLessException : ValidateException
    {
        public NotLessException()
        {
            _message = "Candidate is not less.";
            _code = ExceptionType.NOT_LESS;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
