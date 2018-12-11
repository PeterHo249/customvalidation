using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class List : Arrangement
    {
        private static readonly Lazy<List> lazy = new Lazy<List>(() => new List());

        public static List Instance { get { return lazy.Value; } }

        private List()
        {
        }

        public override dynamic Arrange(ValidateResult result)
        {
            return result.GetList();
        }
    }
}