using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class NotEmptyValidator : Validator
    {
        public NotEmptyValidator(string message = null): base(message)
        {

        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (candidate is string && candidate.Length == 0)
            {
                //return new ValidateException(ExceptionType.EMPTY, _message);
                ValidateException ex = Builder.exceptionFactory.GetValidateException(ExceptionType.EMPTY);
                if (_message != null)
                    ex.Message = _message;
                return ex;
            }

            if (!(candidate is ICollection<dynamic>))
            {
                //return new ValidateException(ExceptionType.INVALID_TYPE, "invalid type");
                return Builder.exceptionFactory.GetValidateException(ExceptionType.INVALID_TYPE);
            } 
            else
            {
                if (candidate.Count == 0)
                {
                    //return new ValidateException(ExceptionType.EMPTY, _message);
                    ValidateException ex = Builder.exceptionFactory.GetValidateException(ExceptionType.EMPTY);
                    if (_message != null)
                        ex.Message = _message;
                    return ex;
                }
            }

            return null;
        }
    }
}