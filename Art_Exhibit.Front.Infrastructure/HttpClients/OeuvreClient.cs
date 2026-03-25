using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections;
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

        public async Task<OeuvreDTO?> GetOeuvreAsync(int id) =>
            await http.GetFromJsonAsync<OeuvreDTO>($"Oeuvre/{id}");

        public async Task<OeuvreDTO[]?> GetAllOeuvreAsync() =>
            await http.GetFromJsonAsync<OeuvreDTO[]>("Oeuvre");

        public async Task DeleteOeuvreAsync(int id) =>
            await http.DeleteAsync($"Oeuvre/{id}");

        public async Task UpdateOeuvreAsync(OeuvreDTO oeuvreDTO) =>
            await http.PutAsJsonAsync<OeuvreDTO>($"Oeuvre/{oeuvreDTO.Id}", oeuvreDTO);

        public async Task<string[]> GetCategoriesAsync() =>
            await http.GetFromJsonAsync<string[]>("getcategories") ?? [];

    }
}
