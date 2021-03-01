using System.Text;
using simple_clean_code.Models;

namespace Tester
{
    public static class AddressFakeMother
    {
        public static Address OkAddress()
        {
            return new()
            {
                AddressLine = GenerateMockString(200),
                Number = GenerateMockString(10),
                Floor = GenerateMockString(10),
                Door = GenerateMockString(10),
                ZipCode = 1232
            };
        }

        public static Address FloorTooLong()
        {
            return new Address
            {
                AddressLine = GenerateMockString(200),
                Number = GenerateMockString(10),
                Floor = GenerateMockString(11)
            };
        }

        public static Address DoorTooLong()
        {
            return new Address
            {
                AddressLine = GenerateMockString(200),
                Number = GenerateMockString(10),
                Door = GenerateMockString(11)
            };
        }

        public static Address NoZipCode()
        {
            return new Address
            {
                AddressLine = GenerateMockString(200),
                Number = GenerateMockString(10)
            };
        }

        public static Address NumberTooLong()
        {
            return new Address
            {
                AddressLine = GenerateMockString(200),
                Number = GenerateMockString(11)
            };
        }

        public static Address NoNumber()
        {
            return new Address
            {
                AddressLine = GenerateMockString(200)
            };
        }

        public static Address AddressLineTooLong()
        {
            return new Address
            {
                AddressLine = GenerateMockString(201)
            };
        }

        public static Address NoAddressLine()
        {
            return new Address
            {
                AddressLine = null
            };
        }

        private static string GenerateMockString(int length)
        {
            var generatedString = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                generatedString.Append('a');
            }

            return generatedString.ToString();
        }
    }
}