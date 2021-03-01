using NUnit.Framework;
using simple_clean_code.Application;
using simple_clean_code.Exceptions;
using simple_clean_code.Repository;

namespace Tester
{
    [TestFixture]
    public class UpdateUserAddressFacadeTest
    {
        private IGetUserRepository _getUserRepository = new FakeGetUserRepository();
        private IUpdateUserAddressRepository _updateRepository = new FakeUpdateUserAddressRepository();

        [Test]
        public void ShouldReturnOk()
        {
            const int userId = 1;
            var newAddress = AddressFakeMother.OkAddress();

            var (ok, exception) = new UpdateUserAddressFacade(_getUserRepository, _updateRepository).Exec(userId, newAddress);
            Assert.IsTrue(ok);
            Assert.Null(exception);
        }
        
        [Test]
        public void ShouldReturnFail_with_exception()
        {
            const int userId = default;
            var newAddress = AddressFakeMother.OkAddress();

            var (ok, exception) = new UpdateUserAddressFacade(_getUserRepository, _updateRepository).Exec(userId, newAddress);
            Assert.IsFalse(ok);
            Assert.NotNull(exception);
            Assert.IsTrue(exception is NotFoundException);
            Assert.AreEqual(new NotFoundException("User").Message, exception.Message);
        }
    }
}