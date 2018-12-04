using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class LessValidator : Validator
    {
        dynamic _opposer;

        public LessValidator(dynamic opposer, string message = null) : base(message)
        {
            _opposer = opposer;
        }

        public override ValidateException Validate(dynamic candidate)
        {
            if (!(candidate is IComparable || candidate is IComparable<dynamic>))
            {
                return new ValidateException(0, _message);
            }

            if (candidate.GetType() != _opposer.GetType())
            {
                return new ValidateException(0, _message);
            }
            else
            {
                if (candidate.CompareTo(_opposer) >= 0)
                {
                    return new ValidateException(0, _message);
                }
            }

            return null;
        }
    }
}