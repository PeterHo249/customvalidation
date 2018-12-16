using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class NotNullValidator : Validator
    {
        public NotNullValidator(string message = null) : base(message)
        {

        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (candidate == null)
            {
                ValidateException ex = Builder.exceptionFactory.GetValidateException(ExceptionType.NULL);
                if (_message != null)
                    ex.Message = _message;
                return ex;
            }

            return null;
        }
    }
}