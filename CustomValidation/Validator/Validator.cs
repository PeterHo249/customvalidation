using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public abstract class Validator
    {
        protected string _message = null;

        public Validator(string message = null)
        {
            _message = message;
        }

        public abstract ValidateException Validate(dynamic candidate);
    }
}