using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation.Result
{
    public class ValidateExceptionFactory
    {
        private List<ValidateException> _exceptionSamples;

        public ValidateExceptionFactory()
        {
            _exceptionSamples = new List<ValidateException>();
            _exceptionSamples.Add(new NullException());
            _exceptionSamples.Add(new InvalidTypeException());
            _exceptionSamples.Add(new EmptyException());
            _exceptionSamples.Add(new NotSameTypeException());
            _exceptionSamples.Add(new EqualException());
            _exceptionSamples.Add(new NotEqualException());
            _exceptionSamples.Add(new NotLessException());
            _exceptionSamples.Add(new NotLessOrEqualException());
            _exceptionSamples.Add(new NotGreaterException());
            _exceptionSamples.Add(new NotGreaterOrEqualException());
            _exceptionSamples.Add(new NotMatchException());
            _exceptionSamples.Add(new NotNumberException());
            _exceptionSamples.Add(new NotEmailException());
            _exceptionSamples.Add(new NotDatetimeException());
            _exceptionSamples.Add(new CustomException());
        }

        public ValidateException GetValidateException(ExceptionType type)
        {
            for (int i = 0; i < _exceptionSamples.Count; i++)
            {
                if (_exceptionSamples[i].Code == type)
                    return _exceptionSamples[i].clone();
            }
            return null;
        }
    }
}
