using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<UsersDTO[]> GetAllUsersAsync();
    }
}
