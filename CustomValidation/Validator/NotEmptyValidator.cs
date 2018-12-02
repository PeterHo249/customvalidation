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
                // TODO: implement exception code
                return new ValidateException(0, _message);
            }

            if (!(candidate is ICollection<dynamic>))
            {
                // TODO: implement exception code
                return new ValidateException(0, _message);
            }

            // TODO: Implement code here

            return null;
        }
    }
}