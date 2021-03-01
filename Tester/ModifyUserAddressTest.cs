using System.Text;
using NUnit.Framework;
using simple_clean_code.Exceptions;
using simple_clean_code.Models;
using simple_clean_code.UseCases;
using ValidationException = simple_clean_code.Exceptions.ValidationException;

namespace Tester
{
    [TestFixture]
    public class ModifyUserAddressTest
    {
        [Test]
        public void Should_returnUser_with_address_modified()
        {
            var originalUser = UserFakeMother.BuildUserWithAddress();
            var newAddress = AddressFakeMother.OkAddress();

            var (updatedUser, exception) = new ModifyUserAddress(originalUser).UpdateUserAddress(newAddress);
            Assert.NotNull(updatedUser);
            Assert.Null(exception);

            Assert.AreEqual(updatedUser.PrimaryAddress, newAddress);
        }

        [Test]
        public void Should_returnNotFound_user_exception()
        {
            var (_, exception) = new ModifyUserAddress(null).UpdateUserAddress(null);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is NotFoundException);
            Assert.AreEqual(new NotFoundException("User").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_Address()
        {
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(null);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_NoAddressLine()
        {
            var newAddress = AddressFakeMother.NoAddressLine();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_AddressLineTooLong()
        {
            var newAddress = AddressFakeMother.AddressLineTooLong();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_NoNumber()
        {
            var newAddress = AddressFakeMother.NoNumber();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_NumberTooLong()
        {
            var newAddress = AddressFakeMother.NumberTooLong();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_NoZipCode()
        {
            var newAddress = AddressFakeMother.NoZipCode();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_DoorTooLong()
        {
            var newAddress = AddressFakeMother.DoorTooLong();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }

        [Test]
        public void Should_returnValidationException_FloorTooLong()
        {
            var newAddress = AddressFakeMother.FloorTooLong();
            var (_, exception) = new ModifyUserAddress(UserFakeMother.BuildUserWithAddress()).UpdateUserAddress(newAddress);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is ValidationException);
            Assert.AreEqual(new ValidationException("address").Message, exception.Message);
        }
    }
}