using System;

namespace simple_clean_code.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string itemName) : base($"NotFound<{itemName}>")
        {
        }
    }
}