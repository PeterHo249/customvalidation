using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public abstract class AbstractCompositeValidate
    {
        protected ValidateResult _result;

        public abstract void Validate();

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

        public abstract dynamic ValidateAndGetResult(Arrangement arrangement);
    }
}
