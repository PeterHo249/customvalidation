using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class EqualException : ValidateException
    {
        public EqualException()
        {
            _message = "Candidate is equal.";
            _code = ExceptionType.EQUAL;
        }
        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
