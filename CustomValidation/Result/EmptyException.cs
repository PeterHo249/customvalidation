using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class EmptyException : ValidateException
    {
        public EmptyException()
        {
            _message = "Candidate is empty.";
            _code = ExceptionType.EMPTY;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
