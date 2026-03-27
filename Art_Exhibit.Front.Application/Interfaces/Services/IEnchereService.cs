using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.Services
{
    public interface IEnchereService
    {
        Task CreateEnchereAsync(CreateEnchereDTO enchereDTO);
        Task<EnchereDTO[]?> GetAllEnchereAsync();
        Task<EnchereDTO> GetEnchereAsync(int id);

        Task UpdateEnchereAsync(EnchereDTO enchereDTO,int id);

        Task DeleteEnchereAsync(int id);


        Task<EnchereDTO?> GetEnchereByArtworkAsync(int id);
    }
}
