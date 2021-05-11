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
        private readonly CreateViewModel<TodayViewModel> _createTodayViewModel;
        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;
        private readonly CreateViewModel<SettingsViewModel> _createSettingsViewModel;

        public ToDoViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel,
                                    CreateViewModel<LoginViewModel> createLoginViewModel,
                                    CreateViewModel<SettingsViewModel> createSettingsViewModel, 
                                    CreateViewModel<TodayViewModel> createTodayViewModel)
        {
            _createHomeViewModel = createHomeViewModel;
            _createLoginViewModel = createLoginViewModel;
            _createSettingsViewModel = createSettingsViewModel;
            _createTodayViewModel = createTodayViewModel;
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
                case ViewType.Today:
                    return _createTodayViewModel();
                case ViewType.Week:
                    return new WeekViewModel();
                case ViewType.Month:
                    return new MonthViewModel();
                default: throw new ArgumentException("The ViewType does not have a ViewModel", "viewType");
            }
        }
    }
}
