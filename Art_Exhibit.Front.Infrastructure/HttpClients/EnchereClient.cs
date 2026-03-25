using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure.HttpClients
{
    public class EnchereClient(HttpClient http):IEnchereClient
    {
        public async Task CreateEnchereAsync(CreateEnchereDTO enchereDTO) =>
            await http.PostAsJsonAsync<CreateEnchereDTO>("Enchere", enchereDTO);
    }
}
