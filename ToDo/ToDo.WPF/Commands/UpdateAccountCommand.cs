using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Services;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.Commands
{
    public class UpdateAccountCommand : AsyncCommandBase
    {
        private readonly IAccountService _accountService;
        private readonly AccountViewModel _accountViewModel;
        public UpdateAccountCommand(AccountViewModel accountViewModel, IAccountService accountService)
        {
            _accountService = accountService;
            _accountViewModel = accountViewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            await _accountService.Update(_accountViewModel.CurrentUser.Id, _accountViewModel.CurrentUser);
        }
    }
}
