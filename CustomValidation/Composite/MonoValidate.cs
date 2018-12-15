using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class MonoValidate : AbstractCompositeValidate
    {
        private dynamic _candidate;
        private List<Validator> _validators;
        

        public MonoValidate(dynamic candidate)
        {
            _candidate = candidate;
            _validators = new List<Validator>();
        }

        public void Add(Validator validator)
        {
            _validators.Add(validator);
        }

        public override void Validate()
        {
            _result = new ValidateResult();
            foreach (Validator validator in _validators)
            {
                ValidateException exception = validator.Validate(_candidate);
                if (exception != null)
                    _result.Add(exception);
            }
        }

        public override dynamic ValidateAndGetResult(Arrangement arrangement)
        {
            Validate();
            return arrangement.Arrange(_result);
        }
    }
}