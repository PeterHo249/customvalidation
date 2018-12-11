using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomValidation
{
    public class RegularExpressionValidator : Validator
    {
        private string _pattern;

        public RegularExpressionValidator(string pattern, string message = null) : base(message)
        {
            _pattern = pattern;
        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (!(candidate is string))
            {
                return new ValidateException(ExceptionType.INVALID_TYPE);
            }

            Regex regex = new Regex(_pattern);

            if (!regex.IsMatch(candidate))
            {
                return new ValidateException(ExceptionType.NOT_MATCH, _message);
            }

            return null;
        }
    }
}