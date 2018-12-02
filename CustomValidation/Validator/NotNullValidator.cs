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
                // TODO: Implement exception code
                return new ValidateException(0, _message);
            }

            return null;
        }
    }
}