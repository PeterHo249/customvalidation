using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class CompositeValidate : IComponentValidate
    {
        private List<IComponentValidate> _objects;
        private Arrangement _arrangement;
        private ValidateResult _result;

        public CompositeValidate()
        {
            this._objects = new List<IComponentValidate>();
            _arrangement = String.Instance;
        }

        public void Add(IComponentValidate component)
        {
            _objects.Add(component);
        }

        public void SetArrangement(Arrangement arrangement)
        {
            this._arrangement = arrangement;
        }

        public void Validate()
        {
            foreach (IComponentValidate component in _objects)
            {
                component.Validate();
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
            return arrangement.Arrange(_result);
        }

        public dynamic ValidateAndGetResult(Arrangement arrangement)
        {
            Validate();
            return GetResult(arrangement);
        }
    }
}