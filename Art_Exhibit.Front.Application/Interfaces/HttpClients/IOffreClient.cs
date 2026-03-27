using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.HttpClients
{
    public interface IOffreClient
    {

        Task CreateOffreAsync(CreateOffreDTO offreDTO);

        Task<OffreDTO?> GetLastBid(int enchereid);

        Task<OffreDTO[]?> GetBids(int enchereid);
    }
}
