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



        public async Task<string[]> GetCategoriesAsync() =>
            await client.GetCategoriesAsync();
    }
}
