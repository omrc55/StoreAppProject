﻿using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
        Task<IdentityResult> CreateUser(UserDtoForCreation userDto);
        Task<IdentityUser> GetOneUser(string userName);
        Task<UserDtoForUpdate> GetOneUserForUpdate(string userName);
        Task UpdateUser(UserDtoForUpdate userDto);
        Task<IdentityResult> AddRole(AddRoleDto addRoleDto);
        Task<IdentityResult> ResetPassword(ResetPasswordDto model);
    }
}