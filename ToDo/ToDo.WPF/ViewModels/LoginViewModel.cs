using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.WPF.Commands;
using ToDo.WPF.State.Authenticators;
using ToDo.WPF.State.Navigators;

namespace ToDo.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set 
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public MessageViewModel ErrorMessageViewModel { get; }

        public string ErrorMessage { set => ErrorMessageViewModel.Message = value; }
        public ICommand LoginCommand { get; }
        public LoginViewModel(IAuthenticator authenticator, IRenavigator renavigator, MessageViewModel errorMessageViewModel)
        {
            LoginCommand = new LoginCommand(authenticator, this, renavigator);
            ErrorMessageViewModel = errorMessageViewModel;
        }

    }
}
