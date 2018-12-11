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
                return new ValidateException(ExceptionType.EMPTY, _message);
            }

            if (!(candidate is ICollection<dynamic>))
            {
                return new ValidateException(ExceptionType.INVALID_TYPE, "invalid type");
            } 
            else
            {
                if (candidate.Count == 0)
                {
                    return new ValidateException(ExceptionType.EMPTY, _message);
                }
            }

            return null;
        }
    }
}