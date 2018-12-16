using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public class CompositeValidate : ComponentValidate
    {
        private List<ComponentValidate> _validates;

        public CompositeValidate()
        {
            _validates = new List<ComponentValidate>();
        }

        public override void Add(dynamic item)
        {
            _validates.Add(item);
        }

        public override void SetValidator(dynamic validator)
        {
            _validates.AddRange(validator.Validates);
        }

        public override void Validate(dynamic candidate)
        {
            _result = new ValidateResult();
            for (int i = 0; i < _validates.Count; i++)
            {
                var exceptions = _validates[i].ValidateAndGetResult(_validates[i].Lambda(candidate), List.Instance);
                if (exceptions != null)
                {
                    _result.Add(exceptions);
                }
            }
        }
    }
}
