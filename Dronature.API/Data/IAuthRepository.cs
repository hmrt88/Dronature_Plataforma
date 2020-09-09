using System;
using System.Threading.Tasks;
using Dronature.API.Models;

namespace Dronature.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExist(string username);
    }
}
