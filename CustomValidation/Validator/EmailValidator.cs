using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class EmailValidator : Validator
    {
        public override ValidateException Validate(dynamic candidate)
        {
            throw new NotImplementedException();
        }
    }
}