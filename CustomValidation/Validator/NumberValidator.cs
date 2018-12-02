using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class NumberValidator : Validator
    {
        public override ValidateException Validate(dynamic candidate)
        {
            throw new NotImplementedException();
        }
    }
}