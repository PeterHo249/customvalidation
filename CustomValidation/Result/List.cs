using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class List : Arrangement
    {
        public override dynamic Arrange(ValidateResult result)
        {
            return result.GetList();
        }
    }
}