using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.WPF.State.Authenticators;
using ToDo.WPF.State.Navigators;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly INavigator _navigator;
        private readonly IAuthenticator _authenticator;

        public LoginCommand(IAuthenticator authenticator, LoginViewModel loginViewModel, INavigator navigator)
        {
            _authenticator = authenticator;
            _loginViewModel = loginViewModel;
            _navigator = navigator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            bool success = await _authenticator.Login(_loginViewModel.Username, parameter.ToString());

            if(success)
            {
                //_navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Home);
            }
        }
    }
}
