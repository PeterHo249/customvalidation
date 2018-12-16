using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class MonoValidate : ComponentValidate
    {
        private List<Validator> _validators;
        
        
        public MonoValidate()
        {
            _validators = new List<Validator>();
        }

        public override void Add(dynamic validator)
        {
            _validators.Add(validator);
        }

        public override void Validate(dynamic candidate)
        {
            _result = new ValidateResult();
            foreach (Validator validator in _validators)
            {
                ValidateException exception = validator.Validate(candidate);
                if (exception != null)
                    _result.Add(exception);
            }
        }
    }
}