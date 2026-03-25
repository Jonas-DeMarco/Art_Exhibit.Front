using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure.HttpClients
{
    internal class OeuvreClient(HttpClient http) : IOeuvreClient
    {
        public async Task CreateOeuvreAsync(CreateOeuvreDTO oeuvreDTO)
        {
            await http.PostAsJsonAsync("Oeuvre", oeuvreDTO);
        }

        public async Task<string[]> GetCategoriesAsync() =>
            await http.GetFromJsonAsync<string[]>("getcategories") ?? [];
    }
}
