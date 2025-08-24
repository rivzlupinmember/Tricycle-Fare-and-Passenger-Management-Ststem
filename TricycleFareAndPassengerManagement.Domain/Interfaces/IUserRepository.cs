﻿using TricycleFareAndPassengerManagement.Domain.Entities;

namespace TricycleFareAndPassengerManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        #region Public Methods

        Task<User?> GetByIdAsync(Guid id);

        Task<User?> GetByEmailAsync(string email);

        Task<User> CreateAsync(User user);

        Task<User> UpdateAsync(User user);

        Task<bool> DeleteAsync(Guid id);

        Task<IEnumerable<User>> GetAllAsync();

        Task<bool> ExistsAsync(string email);

        #endregion Public Methods
    }
}