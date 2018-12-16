using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomValidation 
{
    public class EmailValidator : Validator
    {
        public EmailValidator(string message = null): base(message)
        {

        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (!(candidate is string))
            {
                //return new ValidateException(ExceptionType.INVALID_TYPE);
                return Builder.exceptionFactory.GetValidateException(ExceptionType.INVALID_TYPE);
            }

            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex regex = new Regex(pattern);
            
            if (!regex.IsMatch(candidate))
            {
                //return new ValidateException(ExceptionType.NOT_EMAIL, _message);
                ValidateException ex = Builder.exceptionFactory.GetValidateException(ExceptionType.NOT_EMAIL);
                if (_message != null)
                    ex.Message = _message;
                return ex;
            }

            return null;
        }
    }
}