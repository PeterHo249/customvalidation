using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public interface IComponentValidate
    {
        void Validate();
        bool IsValid();
        dynamic GetResult(Arrangement arrangement);
        dynamic ValidateAndGetResult(Arrangement arrangement);
    }
}