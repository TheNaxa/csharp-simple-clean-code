using System;

namespace simple_clean_code.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string validationName) : base($"Validation<{validationName}>")
        {
        }
    }
}