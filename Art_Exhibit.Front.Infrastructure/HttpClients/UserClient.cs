using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure.HttpClients
{
    public class UserClient(HttpClient http) : IUserClient
    {
        public async Task<UsersDTO[]> GetAllUsersAsync()
        {
            try
            {
                var result = await http.GetFromJsonAsync<UsersDTO[]>("User") ?? [];
                return result;
            }
            catch (Exception ex)
            {

                    throw ex;
            }
            
            
        }

        public async Task<UsersDTO?> GetUserAsync(int id)
        {
            return await http.GetFromJsonAsync<UsersDTO>($"User/{id}");
        }

        public async Task<UsersDTO?> GetUserByUsernameAsync(string username) =>
            await http.GetFromJsonAsync<UsersDTO>($"User/{username}");

        public async Task DeleteUserAsync(int id)
        {
            await http.DeleteAsync($"User/{id}");
        }

        public async Task CreateUserAsync(CreateUserDTO usersDTO)
        {
            await http.PostAsJsonAsync("User", usersDTO);
        }

        public async Task UpdateUserAsync(UsersDTO usersDTO)
        {
            await http.PutAsJsonAsync($"User/{usersDTO.Id}", usersDTO);
        }

        public async Task<string[]> GetTypesAsync() =>
            await http.GetFromJsonAsync<string[]>("gettypes") ?? [];

        public async Task<string[]> GetArtistsAsync()=>
            await http.GetFromJsonAsync<string[]>("getartists") ?? [];
        
    }
}
