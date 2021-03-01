using simple_clean_code.Models;

namespace simple_clean_code.Repository
{
    public interface IGetUserRepository
    {
        public User GetById(int userId);
    }
}