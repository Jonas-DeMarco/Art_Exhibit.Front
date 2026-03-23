using Art_Exhibit.Front.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.Interfaces.HttpClients
{
    public interface IUserClient
    {
        Task<UsersDTO[]> GetAllUsersAsync();
    }
}
