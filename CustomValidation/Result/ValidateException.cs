using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidation
{
    public enum ExceptionType
    {
        NULL,
        INVALID_TYPE,
        EMPTY,
        NOT_SAME_TYPE,
        EQUAL,
        NOT_EQUAL,
        NOT_LESS,
        NOT_LESS_OR_EQUAL,
        NOT_GREATER,
        NOT_GREATER_OR_EQUAL,
        NOT_MATCH,
        NOT_NUMBER,
        NOT_EMAIL,
        NOT_DATETIME,
        CUSTOM
    }
    public class ValidateException
    {
        private ExceptionType _code;
        private string _message;

        public ValidateException(ExceptionType code, string message)
        {
            _code = code;
            if (message == null)
                _message = "Unknown";
            else
                _message = message;
        }
        public override string ToString()
        {
            return _message;
        }
    }
}
