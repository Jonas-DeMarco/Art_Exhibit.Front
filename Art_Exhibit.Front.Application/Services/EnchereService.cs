using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using Art_Exhibit.Front.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Services
{
    public class EnchereService(IEnchereClient client):IEnchereService
    {
        public async Task CreateEnchereAsync(CreateEnchereDTO enchereDTO)=>
            await client.CreateEnchereAsync(enchereDTO);

        public async Task<EnchereDTO[]?> GetAllEnchereAsync() =>
            await client.GetAllEnchereAsync();

        public async Task<EnchereDTO> GetEnchereAsync(int id) =>
            await client.GetEnchereAsync(id);

        public async Task UpdateEnchereAsync(EnchereDTO enchereDTO, int id) =>
            await client.UpdateEnchereAsync(enchereDTO, id);

        public async Task DeleteEnchereAsync(int id) =>
            await client.DeleteEnchereAsync(id);


        public async Task<EnchereDTO?> GetEnchereByArtworkAsync(int id) =>
            await client.GetEnchereByArtworkAsync(id);
    }
}
