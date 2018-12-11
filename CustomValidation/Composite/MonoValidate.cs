using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class MonoValidate : IComponentValidate
    {
        private dynamic _candidate;
        private List<Validator> _validators;
        private ValidateResult _result;

        public MonoValidate(dynamic candidate)
        {
            _candidate = candidate;
            _validators = new List<Validator>();
        }

        public void AddValidator(Validator validator)
        {
            _validators.Add(validator);
        }

        public void Validate()
        {
            _result = new ValidateResult();
            foreach (Validator validator in _validators)
            {
                ValidateException exception = validator.Validate(_candidate);
                if (exception != null)
                    _result.Add(exception);
            }
        }

        public bool IsValid()
        {
            if (_result == null || _result.IsValid())
                return true;
            else
                return false;
        }

        public dynamic GetResult(Arrangement arrangement)
        {
            return arrangement.Arrange(this._result);
        }

        public dynamic ValidateAndGetResult(Arrangement arrangement)
        {
            Validate();
            return arrangement.Arrange(_result);
        }
    }
}