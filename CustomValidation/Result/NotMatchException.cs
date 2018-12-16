using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotMatchException : ValidateException
    {
        public NotMatchException()
        {
            _message = "Candidate is not match.";
            _code = ExceptionType.NOT_MATCH;
        }
        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
