using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public abstract class ComponentValidate
    {
        protected ValidateResult _result;
        private Func<dynamic, dynamic> _lambda;
        public Func<dynamic, dynamic> Lambda { get => _lambda; set => _lambda = value; }

        public abstract void Validate(dynamic candidate);
        public abstract void Add(dynamic item);

        public virtual void SetValidator(dynamic validator)
        {
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

        public dynamic ValidateAndGetResult(dynamic candidate, Arrangement arrangement)
        {
            Validate(candidate);
            return GetResult(arrangement);
        }
    }
}
