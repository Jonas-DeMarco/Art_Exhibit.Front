using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using Art_Exhibit.Front.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Services
{
    public class OffreService(IOffreClient client) : IOffreService
    {

        public async Task CreateOffreAsync(CreateOffreDTO offreDTO) =>
            await client.CreateOffreAsync(offreDTO);

        public async Task<OffreDTO?> GetLastBid(int enchereid)=>
            await client.GetLastBid(enchereid);

        public async Task<OffreDTO[]?> GetBids(int enchereid) =>
            await client.GetBids(enchereid);
    }
}
