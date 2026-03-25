using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using Art_Exhibit.Front.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Services
{
    public class OeuvreService(IOeuvreClient client) : IOeuvreService
    {
        public async Task CreateOeuvreAsync(CreateOeuvreDTO oeuvreDTO) =>
            await client.CreateOeuvreAsync(oeuvreDTO);

        public async Task<OeuvreDTO?> GetOeuvreAsync(int id) =>
            await client.GetOeuvreAsync(id);

        public async Task UpdateOeuvreAsync(OeuvreDTO oeuvreDTO)
            => await client.UpdateOeuvreAsync(oeuvreDTO);

        public async Task DeleteOeuvreAsync(int id) =>
              await client.DeleteOeuvreAsync(id);

        public async Task<OeuvreDTO[]?> GetAllOeuvreAsync() =>
            await client.GetAllOeuvreAsync();

        public async Task<string[]> GetCategoriesAsync() =>
            await client.GetCategoriesAsync();
    }
}
