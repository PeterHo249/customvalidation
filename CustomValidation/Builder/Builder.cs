using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class Builder
    {
        private MonoValidate _object;
        private static Builder _instance = null;
        private Builder()
        {

        }
        public static Builder GetBuilder()
        {
            if (_instance == null)
                _instance = new Builder();
            return _instance;
        }

        public MonoValidate GetProduct()
        {
            return this._object; ;
        }

        Builder RuleFor(dynamic candidate)
        {
            this._object = new MonoValidate(candidate);
            return this;
        }

        Builder IsEqual(dynamic x)
        {
            this._object.AddValidator(new EqualValidator(x));
            return this;
        }

        Builder IsNotEqual(dynamic x)
        {
            this._object.AddValidator(new NotEqualValidator(x));
            return this;
        }

        Builder IsGreaterThan(dynamic x)
        {
            this._object.AddValidator(new GreaterValidator(x));
            return this;
        }

        Builder IsGreaterThanOrEqual(dynamic x)
        {
            this._object.AddValidator(new GreaterEqualValidator(x));
            return this;
        }

        Builder IsLessThan(dynamic x)
        {
            this._object.AddValidator(new LessValidator(x));
            return this;
        }

        Builder IsLessThanOrEqual(dynamic x)
        {
            this._object.AddValidator(new LessEqualValidator(x));
            return this;
        }

        Builder IsBetween(dynamic x1, dynamic x2)
        {
            this._object.AddValidator(new BetweenValidator(x1, x2));
            return this;
        }

        Builder IsNotNull()
        {
            this._object.AddValidator(new NotNullValidator());
            return this;
        }

        Builder RegularExpression(string rgx)
        {
            this._object.AddValidator(new RegularExpressionValidator(rgx));
            return this;
        }

        Builder IsEmail()
        {
            this._object.AddValidator(new EmailValidator());
            return this;
        }
        Builder IsNumber()
        {
            this._object.AddValidator(new NumberValidator());
            return this;
        }

        Builder IsPhoneNumber()
        {
            this._object.AddValidator(new PhoneNumberValidator());
            return this;
        }

        Builder IsVisa()
        {
            this._object.AddValidator(new VisaValidator());
            return this;
        }

        Builder Must(Validator v)
        {
            this._object.AddValidator(v);
            return this;
        }
    }
}