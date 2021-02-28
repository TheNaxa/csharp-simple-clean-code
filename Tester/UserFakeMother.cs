using simple_clean_code.Models;

namespace Tester
{
    public static class UserFakeMother
    {
        public static User BuildUserWithAddress()
        {
            return new()
            {
                Id = 1,
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