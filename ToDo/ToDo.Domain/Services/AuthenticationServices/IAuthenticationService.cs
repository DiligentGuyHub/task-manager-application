﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Services
{
    public interface IAuthenticationService
    {
        Task<bool> Register(string email, string username, string password, string confirmepassword);
        Task<User> Login(string username, string password);
    }
}
