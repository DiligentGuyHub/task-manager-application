using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.WPF.State.Navigators;

namespace ToDo.WPF.ViewModels.Factories
{
    public class ToDoViewModelFactory : IToDoViewModelAbstractFactory
    {
        private readonly IToDoViewModelFactory<HomeViewModel> _homeViewModelFactory;
        private readonly IToDoViewModelFactory<InboxViewModel> _inboxViewModelFactory;
        private readonly IToDoViewModelFactory<LoginViewModel> _loginViewModelFactory;
        private readonly IToDoViewModelFactory<SettingsViewModel> _settingsViewModelFactory;

        public ToDoViewModelFactory(
            IToDoViewModelFactory<HomeViewModel> homeViewModelFactory,
            IToDoViewModelFactory<InboxViewModel> inboxViewModelFactory, 
            IToDoViewModelFactory<LoginViewModel> loginViewModelFactory,
            IToDoViewModelFactory<SettingsViewModel> settingsViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
            _inboxViewModelFactory = inboxViewModelFactory;
            _loginViewModelFactory = loginViewModelFactory;
            _settingsViewModelFactory = settingsViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _loginViewModelFactory.CreateViewModel();
                case ViewType.Settings:
                    return _settingsViewModelFactory.CreateViewModel();
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                case ViewType.Inbox:
                    return _inboxViewModelFactory.CreateViewModel();
                case ViewType.Today:
                    return new TodayViewModel();
                case ViewType.Week:
                    return new WeekViewModel();
                case ViewType.Month:
                    return new MonthViewModel();
                default: throw new ArgumentException("The ViewType does not have a ViewModel", "viewType");
            }
        }
    }
}
