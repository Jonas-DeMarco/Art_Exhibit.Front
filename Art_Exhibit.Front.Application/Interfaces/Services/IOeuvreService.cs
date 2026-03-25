using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.Services
{
    public interface IOeuvreService
    {
        Task CreateOeuvreAsync(CreateOeuvreDTO oeuvreDTO);



        Task<string[]> GetCategoriesAsync();
    }
}
