using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public interface IComponentValidate
    {
        bool Validate();
        bool IsValid();
        dynamic GetResult(Arrangement arm);
        dynamic ValidateAndGetResult(Arrangement arm);
    }
}