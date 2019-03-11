using ComiCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiAPI.Services
{
    public interface IUserService
    {
        ApplicationUser Authenticate(string email, string password);
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
        ApplicationUser GetByEmail(string email);
        Task<ApplicationUser> CreateAsync(string email, string password);
    }
}
