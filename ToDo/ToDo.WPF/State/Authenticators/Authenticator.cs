﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;
using ToDo.Domain.Services;

namespace ToDo.WPF.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;

        public Authenticator(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public User CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;

        public async Task<bool> Login(string username, string password)
        {
            bool success = true;
            try
            {
                CurrentUser = await _authenticationService.Login(username, password);
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }
        public void Logout()
        {
            CurrentUser = null;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmpassword)
        {
            return await _authenticationService.Register(email, username, password, confirmpassword);
        }
    }
}