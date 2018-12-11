using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class String : Arrangement
    {
        private char _delimiter;

        public String(char delimiter = '\n')
        {
            _delimiter = delimiter;
        }

        public override dynamic Arrange(ValidateResult result)
        {
            List<ValidateException> exceptions = result.GetList();
            string s = "";
            for (int i = 0; i < exceptions.Count - 1; i++)
                s += exceptions[i].ToString() + _delimiter;
            s += exceptions[exceptions.Count - 1].ToString();
            return s;
        }
    }
}