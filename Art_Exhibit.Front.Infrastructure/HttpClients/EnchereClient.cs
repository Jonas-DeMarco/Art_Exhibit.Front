using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure.HttpClients
{
    public class EnchereClient(HttpClient http) : IEnchereClient
    {
        public async Task CreateEnchereAsync(CreateEnchereDTO enchereDTO) =>
            await http.PostAsJsonAsync<CreateEnchereDTO>("Enchere", enchereDTO);

        public async Task<EnchereDTO[]> GetAllEnchereAsync() =>
            await http.GetFromJsonAsync<EnchereDTO[]>("Enchere") ?? [];

        public async Task<EnchereDTO> GetEnchereAsync(int id) =>
            await http.GetFromJsonAsync<EnchereDTO>($"Enchere/{id}");

        public async Task UpdateEnchereAsync(EnchereDTO enchereDTO, int id)
            => await http.PutAsJsonAsync($"Enchere/{id}",enchereDTO);


        public async Task DeleteEnchereAsync(int id) =>
            await http.DeleteAsync("Enchere/{id}");

        public async Task<EnchereDTO?> GetEnchereByArtworkAsync(int id)
        {
            try
            {
                var result = await http.GetFromJsonAsync<EnchereDTO?>($"Enchere/getfromartwork/{id}") ?? null;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
            
    }
}
