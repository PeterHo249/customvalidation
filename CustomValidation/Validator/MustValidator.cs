using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class MustValidator : Validator
    {
        private Func<dynamic, bool> _func;

        public MustValidator(Func<dynamic, bool> func, string message = null): base(message)
        {
            _func = func;
        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (!_func(candidate))
            {
                return new ValidateException(ExceptionType.CUSTOM, _message);
            }

            return null;
        }
    }
}