using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotNumberException : ValidateException
    {
        public NotNumberException()
        {
            _message = "Candidate is not number.";
            _code = ExceptionType.NOT_NUMBER;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
