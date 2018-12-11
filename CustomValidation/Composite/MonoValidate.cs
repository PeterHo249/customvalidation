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
            this._candidate = candidate;
            this._validators = new List<Validator>();
            this._result = new ValidateResult();
        }

        public void AddValidator(Validator validator)
        {
            this._validators.Add(validator);
        }

        public bool Validate()
        {
            bool isValid = true;
            foreach (Validator v in this._validators)
            {
                ValidateException ex = v.Validate(this._candidate);
                if (ex != null)
                {
                    this._result.Add(ex);
                    isValid = false;
                }
            }
            return isValid;
        }

        public bool IsValid()
        {
            return Validate();
        }

        public dynamic GetResult(Arrangement arm)
        {
            return arm.Arrange(this._result);
        }
        public dynamic ValidateAndGetResult(Arrangement arm)
        {
            if (Validate())
            {
                return null;
            }
            else
            {
                return GetResult(arm);
            }
        }
    }
}