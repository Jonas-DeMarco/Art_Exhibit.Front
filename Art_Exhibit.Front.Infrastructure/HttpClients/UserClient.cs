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
            var result = await http.GetFromJsonAsync<UsersDTO[]>("User") ?? [];
            return result;
        }
        
    }
}
