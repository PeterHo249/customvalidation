using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotDatetimeException : ValidateException
    {
        public NotDatetimeException()
        {
            _message = "Candidate is not date time.";
            _code = ExceptionType.NOT_DATETIME;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
