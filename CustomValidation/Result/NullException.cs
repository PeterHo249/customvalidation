using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NullException : ValidateException
    {
        public NullException()
        {
            _message = "Candidate is null.";
            _code = ExceptionType.NULL;
        }

        public override ValidateException clone()
        {
            return (ValidateException) this.MemberwiseClone();
        }
    }
}
