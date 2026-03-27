using Art_Exhibit.Front.Application.DTOs;
using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure.HttpClients
{
    public class OffreClient(HttpClient http) : IOffreClient
    {
        public async Task CreateOffreAsync(CreateOffreDTO offreDTO) =>
            await http.PostAsJsonAsync<CreateOffreDTO>("Offre", offreDTO);



        public async Task<OffreDTO?> GetLastBid(int enchereid)
        {
            try 
            {
                var result =  await http.GetFromJsonAsync<OffreDTO>($"Offre/lastbid/{enchereid}");
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
            

        public async Task<OffreDTO[]?> GetBids(int enchereid) =>
            await http.GetFromJsonAsync<OffreDTO[]>($"Offre/bids/{enchereid}");

       
    }
}
