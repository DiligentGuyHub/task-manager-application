using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.WPF.State.Navigators;

namespace ToDo.WPF.ViewModels.Factories
{
    public class ToDoViewModelFactory : IToDoViewModelFactory
    {
        private readonly CreateViewModel<HomeViewModel> _createHomeViewModel;
        private readonly CreateViewModel<InboxViewModel> _createInboxViewModel;
        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;
        private readonly CreateViewModel<SettingsViewModel> _createSettingsViewModel;

        public ToDoViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel,
                                    CreateViewModel<InboxViewModel> createInboxViewModel,
                                    CreateViewModel<LoginViewModel> createLoginViewModel,
                                    CreateViewModel<SettingsViewModel> createSettingsViewModel)
        {
            _createHomeViewModel = createHomeViewModel;
            _createInboxViewModel = createInboxViewModel;
            _createLoginViewModel = createLoginViewModel;
            _createSettingsViewModel = createSettingsViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _createLoginViewModel();
                case ViewType.Settings:
                    return _createSettingsViewModel();
                case ViewType.Home:
                    return _createHomeViewModel();
                case ViewType.Inbox:
                    return _createInboxViewModel();
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
