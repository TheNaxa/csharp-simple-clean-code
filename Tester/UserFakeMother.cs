using simple_clean_code.Models;

namespace Tester
{
    public static class UserFakeMother
    {
        public static User BuildUserWithAddress()
        {
            return BuildUserWithAddress(1);
        }
        
        public static User BuildUserWithAddress(int userId)
        {
            return new()
            {
                Id = userId,
                Name = "name",
                LastName = "last_name",
                PrimaryAddress = new Address
                {
                    AddressLine = "bla bla bla",
                    Number = "1021",
                    Floor = "34",
                    Door = "D",
                    ZipCode = 2122
                }
            };
        }
    }
}