using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class String : Arrangement
    {
        private char _delimiter = '\n';

        private static readonly Lazy<String> lazy = new Lazy<String>(() => new String());

        public static String Instance { get { return lazy.Value; } }

        public char Delimiter { private get => _delimiter; set => _delimiter = value; }

        private String()
        {
        }


        public override dynamic Arrange(ValidateResult result)
        {
            List<ValidateException> exceptions = result.GetList();
            if (exceptions.Count == 0)
                return "";
            string s = "";
            for (int i = 0; i < exceptions.Count - 1; i++)
                s += exceptions[i].ToString() + Delimiter;
            s += exceptions[exceptions.Count - 1].ToString();
            return s;
        }
    }
}