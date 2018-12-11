using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public class ValidateResult
    {
        private List<ValidateException> _exceptions;

        public ValidateResult()
        {
            _exceptions = new List<ValidateException>() { };
        }

        public void Add(ValidateException exception)
        {
            _exceptions.Add(exception);
        }

        public List<ValidateException> GetList()
        {
            return _exceptions;
        }

        public bool IsValid()
        {
            if (_exceptions == null || _exceptions.Count == 0)
                return true;
            else
                return false;
        }
    }
}