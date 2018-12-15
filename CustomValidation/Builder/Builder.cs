using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class Builder
    {
        private MonoValidate _object;

        private static readonly Lazy<Builder> lazy = new Lazy<Builder>(() => new Builder());

        public static Builder Instance { get { return lazy.Value; } }

        private Builder()
        {
        }

        public MonoValidate GetProduct()
        {
            return _object; ;
        }

        public Builder RuleFor(dynamic candidate)
        {
            _object = new MonoValidate(candidate);
            return this;
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

        Builder RegularExpression(string rgx, string message = null)
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