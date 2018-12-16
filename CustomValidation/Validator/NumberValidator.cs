using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomValidation
{
    public class NumberValidator : Validator
    {
        public NumberValidator(string message = null):base(message)
        {

        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (candidate is sbyte || candidate is byte || candidate is int || candidate is short || 
                candidate is ushort || candidate is uint || candidate is long ||
                candidate is ulong || candidate is float || candidate is double || candidate is decimal)
                return null;

            if (!(candidate is string))
            {
                //return new ValidateException(ExceptionType.INVALID_TYPE);
                return Builder.exceptionFactory.GetValidateException(ExceptionType.INVALID_TYPE);
            }

            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");

            if (!regex.IsMatch(candidate))
            {
                //return new ValidateException(ExceptionType.NOT_NUMBER, _message);
                ValidateException ex = Builder.exceptionFactory.GetValidateException(ExceptionType.NOT_NUMBER);
                if (_message != null)
                    ex.Message = _message;
                return ex;
            }

            return null;
        }
    }
}