using System;
using simple_clean_code.Models;

namespace simple_clean_code.Repository
{
    public interface IUpdateUserAddressRepository
    {
        public (bool, Exception) UpdateAddress(User userWithAddress);
    }
}