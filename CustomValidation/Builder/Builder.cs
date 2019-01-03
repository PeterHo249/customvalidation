using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class Builder
    {
        private ComponentValidate _object;

        public Builder()
        {
        }

        public ComponentValidate GetProduct()
        {
            return _object;
        }

        public Builder RuleFor(dynamic lambda, bool isSimple = true)
        {
            if (isSimple)
            {
                _object = new MonoValidate
                {
                    Lambda = lambda
                };
            }
            else
            {
                _object = new CompositeValidate()
                {
                    Lambda = lambda
                };
            }
            return this;
        }

        public Builder RuleFor(dynamic candidate)
        {
            _object = new MonoValidate();
            return this;
        }

        public void SetValidator(dynamic validator)
        {
            _object.SetValidator(validator);
        }

        public Builder IsEqual(dynamic x, string message = null)
        {
            _object.Add(new EqualValidator(x, message));
            return this;
        }

        public Builder IsNotEqual(dynamic x, string message = null)
        {
            _object.Add(new NotEqualValidator(x, message));
            return this;
        }

        public Builder IsGreaterThan(dynamic x, string message = null)
        {
            _object.Add(new GreaterValidator(x, message));
            return this;
        }

        public Builder IsGreaterThanOrEqual(dynamic x, string message = null)
        {
            _object.Add(new GreaterEqualValidator(x, message));
            return this;
        }

        public Builder IsLessThan(dynamic x, string message = null)
        {
            _object.Add(new LessValidator(x, message));
            return this;
        }

        public Builder IsLessThanOrEqual(dynamic x, string message = null)
        {
            _object.Add(new LessEqualValidator(x, message));
            return this;
        }

        public Builder IsNotNull(string message = null)
        {
            _object.Add(new NotNullValidator(message));
            return this;
        }

        public Builder RegularExpression(string rgx, string message = null)
        {
            _object.Add(new RegularExpressionValidator(rgx, message));
            return this;
        }

        public Builder IsEmail(string message = null)
        {
            _object.Add(new EmailValidator(message));
            return this;
        }

        public Builder IsNumber(string message = null)
        {
            _object.Add(new NumberValidator(message));
            return this;
        }

        public Builder Must(Func<dynamic, bool> func, string message = null)
        {
            _object.Add(new MustValidator(func, message));
            return this;
        }
    }
}