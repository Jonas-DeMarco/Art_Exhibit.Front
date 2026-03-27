using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using Art_Exhibit.Front.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Art_Exhibit.Front.Application.Services
{
    public class UserService(IUserClient userClient) : IUserService
    {
        public async Task<UsersDTO[]> GetAllUsersAsync() =>
            await userClient.GetAllUsersAsync();

        public async Task<UsersDTO> GetUserAsync(int id) =>
            await userClient.GetUserAsync(id);
        public async Task<UsersDTO> GetUserByUsernameAsync(string username) =>
            await userClient.GetUserByUsernameAsync(username);
        public async Task DeleteUserAsync(int id) =>
            await userClient.DeleteUserAsync(id);

        public async Task CreateUserAsync(CreateUserDTO usersDTO) =>
            await userClient.CreateUserAsync(usersDTO);

        public async Task UpdateUserAsync(UsersDTO usersDTO)=>
            await userClient.UpdateUserAsync(usersDTO);

        public async Task<string[]> GetTypesAsync() =>
            await userClient.GetTypesAsync();

        public async Task<string[]> GetArtistsAsync() =>
            await userClient.GetArtistsAsync();

        public async Task<string[]> GetAllUsernameAsync() =>
            await userClient.GetAllUsernameAsync();
    }
}
