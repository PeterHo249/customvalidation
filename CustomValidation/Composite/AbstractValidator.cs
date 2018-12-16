using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public class AbstractValidator<T>
    {
        private T _candidate;
        private List<ComponentValidate> _validates;

        public List<ComponentValidate> Validates { get => _validates; set => _validates = value; }

        public AbstractValidator()
        {
            Validates = new List<ComponentValidate>();
        }

        public Builder RuleFor(Func<dynamic, dynamic> lambda, bool isSimple = true)
        {
            var result = new Builder().RuleFor(lambda, isSimple);
            Validates.Add(result.GetProduct());
            return result;
        }

        public void Validate(T candidate)
        {
            _candidate = candidate;
            for (int i = 0; i < Validates.Count; i++)
            {
                Validates[i].Validate(Validates[i].Lambda(candidate));
            }
        }

        public bool IsValid()
        {
            for (int i = 0; i < Validates.Count; i++)
            {
                if (!Validates[i].IsValid())
                {
                    return false;
                }
            }

            return true;
        }

        public dynamic GetResult(Arrangement arrangement)
        {
            ValidateResult result = new ValidateResult();
            for (int i = 0; i < Validates.Count; i++)
            {
                result.Add(Validates[i].GetResult(List.Instance));
            }

            return arrangement.Arrange(result);
        }

        public dynamic ValidateAndGetResult(T candidate, Arrangement arrangement)
        {
            Validate(candidate);
            return GetResult(arrangement);
        }

    }
}
