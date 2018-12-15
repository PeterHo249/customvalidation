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
        private List<MonoValidate> _validates;

        public AbstractValidator()
        {
            _validates = new List<MonoValidate>();
        }

        public Builder RuleFor(Func<dynamic, dynamic> lambda)
        {
            var result = Builder.Instance.RuleFor(lambda);
            result.GetProduct().lambda = lambda;
            _validates.Add(result.GetProduct());
            return result;
        }

        public void Validate(T candidate)
        {
            _candidate = candidate;
            for (int i = 0; i < _validates.Count; i++)
            {
                _validates[i].Validate(_validates[i].lambda(candidate));
            }
        }

        public bool IsValid()
        {
            for (int i = 0; i < _validates.Count; i++)
            {
                if (!_validates[i].IsValid())
                {
                    return false;
                }
            }

            return true;
        }

        public dynamic GetResult(Arrangement arrangement)
        {
            ValidateResult result = new ValidateResult();
            for (int i = 0; i < _validates.Count; i++)
            {
                result.Add(_validates[i].GetResult(List.Instance));
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
