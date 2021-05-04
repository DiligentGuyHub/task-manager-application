using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDataService<User> _accountService;

        public AuthenticationService(IDataService<User> accountService)
        {
            _accountService = accountService;
        }

        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Register(string email, string username, string password, string confirmepassword)
        {
            bool success = false;
            if(password == confirmepassword)
            {
                IPasswordHasher hasher = new PasswordHasher();
                string passwordhash = hasher.HashPassword(password);

                User user = new User()
                {
                    Username = username,
                    Email = email,
                    PasswordHash = passwordhash,
                    Role = "User",
                    Status = true,
                    DateJoined = DateTime.Now
                };

                await _accountService.Create(user);
            }

            return success;
        }
    }
}
