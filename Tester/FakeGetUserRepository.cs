using simple_clean_code.Models;
using simple_clean_code.Repository;

namespace Tester
{
    public class FakeGetUserRepository : IGetUserRepository
    {
        public User GetById(int userId)
        {
            if (userId == default) return null;
            return UserFakeMother.BuildUserWithAddress(userId);
        }
    }
}