using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    class CompositeValidate : AbstractCompositeValidate
    {
        private List<AbstractCompositeValidate> _validates;

        public CompositeValidate()
        {
            _validates = new List<AbstractCompositeValidate>();
        }

        public void Add(AbstractCompositeValidate validate)
        {
            _validates.Add(validate);
        }

        public override void Validate()
        {
            _result = new ValidateResult();
            for (int i = 0; i < _validates.Count; i++)
            {
                _validates[i].Validate();
                _result.Add(_validates[i].GetResult(List.Instance));
            }
        }

        public override dynamic ValidateAndGetResult(Arrangement arrangement)
        {
            Validate();
            return GetResult(arrangement);
        }
    }
}
