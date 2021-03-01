using System;
using simple_clean_code.Exceptions;
using simple_clean_code.Models;

namespace simple_clean_code.UseCases
{
    public class ModifyUserAddress
    {
        private User User { get; }

        public ModifyUserAddress(User user)
        {
            User = user;
        }

        public (User, Exception) UpdateUserAddress(Address address)
        {
            if (User == null) return (null, new NotFoundException(nameof(User)));
            if (address == null) return (null, new ValidationException(nameof(address)));
            if (!address.Validate()) return (null, new ValidationException(nameof(address)));
            User.PrimaryAddress = address;
            return (User, null);
        }
    }
}