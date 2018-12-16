using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class NotEmailException : ValidateException
    {
        public NotEmailException()
        {
            _message = "Candidate is not email.";
            _code = ExceptionType.NOT_EMAIL;
        }

        public override ValidateException clone()
        {
            return (ValidateException)this.MemberwiseClone();
        }
    }
}
