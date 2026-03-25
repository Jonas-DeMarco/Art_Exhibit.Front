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
    }
}
