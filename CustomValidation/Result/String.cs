using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class String : Arrangement
    {
        private char _delimiter;
        public String(char delimiter)
        {
            _delimiter = delimiter;
        }
        public override dynamic Arrange(ValidateResult result)
        {
            List<ValidateException> exceptions = result.GetList();
            string s = "";
            for (int i = 0; i < exceptions.Count; i++)
                s += _delimiter + exceptions[i].ToString();
            return s;
        }
    }
}