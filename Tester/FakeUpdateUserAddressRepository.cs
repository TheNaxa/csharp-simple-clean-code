using System;
using simple_clean_code.Models;
using simple_clean_code.Repository;

namespace Tester
{
    public class FakeUpdateUserAddressRepository : IUpdateUserAddressRepository
    {
        public (bool, Exception) UpdateAddress(User userWithAddress)
        {
            if (userWithAddress != null) return (true, null);
            return (false, new Exception("Fake Exception"));
        }
    }
}