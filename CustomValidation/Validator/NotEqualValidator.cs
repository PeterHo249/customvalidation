using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class NotEqualValidator : Validator
    {
        dynamic _opposer;

        public NotEqualValidator(dynamic opposer, string message = null):base(message)
        {
            _opposer = opposer;
        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (!(candidate is IComparable || candidate is IComparable<dynamic>))
            {
                return new ValidateException(ExceptionType.INVALID_TYPE, "invalid type");
            }

            if (candidate.GetType() != _opposer.GetType())
            {
                return new ValidateException(ExceptionType.INVALID_TYPE, "not the same type");
            }
            else
            {
                if (candidate.CompareTo(_opposer) == 0)
                {
                    return new ValidateException(ExceptionType.EQUAL, _message);
                }
            }

            return null;
        }
    }
}