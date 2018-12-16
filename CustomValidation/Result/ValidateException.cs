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
    public abstract class ValidateException
    {
        protected ExceptionType _code;
        protected string _message;

        //public ValidateException(ExceptionType code, string message = null)
        //{
        //    _code = code;
        //    if (message == null)
        //    {
        //        switch (code) {
        //            case ExceptionType.EMPTY:
        //                _message = "Candidate is empty.";
        //                break;
        //            case ExceptionType.EQUAL:
        //                _message = "Candidate is equal.";
        //                break;
        //            case ExceptionType.INVALID_TYPE:
        //                _message = "Candidate is invalid type.";
        //                break;
        //            case ExceptionType.NOT_DATETIME:
        //                _message = "Candidate is not date time format.";
        //                break;
        //            case ExceptionType.NOT_EMAIL:
        //                _message = "Candidate is invalid email.";
        //                break;
        //            case ExceptionType.NOT_EQUAL:
        //                _message = "Candidate is not equal.";
        //                break;
        //            case ExceptionType.NOT_GREATER:
        //                _message = "Candidate is not greater.";
        //                break;
        //            case ExceptionType.NOT_GREATER_OR_EQUAL:
        //                _message = "Candidate is not greater or equal.";
        //                break;
        //            case ExceptionType.NOT_LESS:
        //                _message = "Candidate is not less.";
        //                break;
        //            case ExceptionType.NOT_LESS_OR_EQUAL:
        //                _message = "Candidate is not less or equal.";
        //                break;
        //            case ExceptionType.NOT_MATCH:
        //                _message = "Candidate is not match pattern.";
        //                break;
        //            case ExceptionType.NOT_NUMBER:
        //                _message = "Candidate is not number.";
        //                break;
        //            case ExceptionType.NOT_SAME_TYPE:
        //                _message = "Candidate is not same type.";
        //                break;
        //            case ExceptionType.NULL:
        //                _message = "Candidate is null.";
        //                break;
        //            default:
        //                _message = "Candidate is invalid.";
        //                break;
        //        }
        //    }
        //    else
        //        _message = message;
        //}
        //public override string ToString()
        //{
        //    return _message;
        //}

        

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public ExceptionType Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public override string ToString()
        {
            return _message;
        }

        public abstract ValidateException clone();

    }
}
