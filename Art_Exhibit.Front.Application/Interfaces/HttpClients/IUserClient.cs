using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.HttpClients
{
    public interface IUserClient
    {
        Task<UsersDTO[]> GetAllUsersAsync();

        Task<UsersDTO?> GetUserAsync(int id);
        Task<UsersDTO?> GetUserByUsernameAsync(string username);

        Task DeleteUserAsync(int id);

        Task CreateUserAsync(CreateUserDTO usersDTO);

        Task UpdateUserAsync(UsersDTO usersDTO);


        Task<string[]> GetTypesAsync();
        Task<string[]> GetArtistsAsync();

        Task<string[]> GetAllUsernameAsync();
    }
}
