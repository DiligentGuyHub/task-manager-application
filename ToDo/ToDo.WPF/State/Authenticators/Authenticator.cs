using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDo.Domain.Models;
using ToDo.Domain.Services;
using ToDo.WPF.Models;
using ToDo.WPF.State.Accounts;

namespace ToDo.WPF.State.Authenticators
{
    public class Authenticator : ObservableObject, IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IAccountStore _accountStore;

        public Authenticator(IAuthenticationService authenticationService, IAccountStore accountStore)
        {
            _authenticationService = authenticationService;
            _accountStore = accountStore;
        }
        public User CurrentUser 
        {
            get
            {
                return _accountStore.CurrentAccount;
            }
            private set 
            {
                _accountStore.CurrentAccount = value;
                OnPropertyChanged(nameof(CurrentUser));
                OnPropertyChanged(nameof(IsLoggedIn));
            }
        }
        event Action StateChanged;
        public bool IsLoggedIn => CurrentUser != null;

        public async Task<bool> Login(string username, string password)
        {
            bool success = true;
            try
            {
                CurrentUser = await _authenticationService.Login(username, password);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
