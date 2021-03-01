using System;
using simple_clean_code.Models;
using simple_clean_code.Repository;
using simple_clean_code.UseCases;

namespace simple_clean_code.Application
{
    public class UpdateUserAddressFacade
    {
        private IGetUserRepository _getUserRepository;
        private IUpdateUserAddressRepository _updateUserAddressRepository;

        public UpdateUserAddressFacade(IGetUserRepository getUserRepository, IUpdateUserAddressRepository updateUserAddressRepository)
        {
            _getUserRepository = getUserRepository;
            _updateUserAddressRepository = updateUserAddressRepository;
        }

        public (bool ok, Exception exception) Exec(int userId, Address address)
        {
            var user = _getUserRepository.GetById(userId);
            var (userUpdated, exception) = new ModifyUserAddress(user).UpdateUserAddress(address);
            if (exception != null) return (false, exception);
            var (ok, repositoryException) = _updateUserAddressRepository.UpdateAddress(userUpdated);
            if (repositoryException != null) return (false, repositoryException);
            return (ok, null);
        }
    }
}