using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.API.Services;
using ToDo.WPF.State.Navigators;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel(ExchangeRateListingViewModel.LoadExchangeIndexViewModel(new ExchangeRateService()));
                        break;
                    case ViewType.Inbox:
                        _navigator.CurrentViewModel = new InboxViewModel();
                        break;
                    case ViewType.Today:
                        _navigator.CurrentViewModel = new TodayViewModel();
                        break;
                    case ViewType.Week:
                        _navigator.CurrentViewModel = new WeekViewModel();
                        break;
                    case ViewType.Month:
                        _navigator.CurrentViewModel = new MonthViewModel();
                        break;
                    default: break;
                }
            }
        }
    }
}
