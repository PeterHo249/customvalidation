using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotGreaterException : ValidateException
    {
        public NotGreaterException()
        {
            _message = "Candidate is not greater.";
            _code = ExceptionType.NOT_GREATER;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
