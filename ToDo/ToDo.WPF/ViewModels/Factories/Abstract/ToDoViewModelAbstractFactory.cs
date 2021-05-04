using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.WPF.State.Navigators;

namespace ToDo.WPF.ViewModels.Factories
{
    public class ToDoViewModelAbstractFactory : IToDoViewModelAbstractFactory
    {
        private readonly IToDoViewModelFactory<HomeViewModel> _homeViewModelFactory;
        private readonly IToDoViewModelFactory<InboxViewModel> _inboxViewModelFactory;

        public ToDoViewModelAbstractFactory(
            IToDoViewModelFactory<HomeViewModel> homeViewModelFactory,
            IToDoViewModelFactory<InboxViewModel> inboxViewModelFactory
            )
        {
            _homeViewModelFactory = homeViewModelFactory;
            _inboxViewModelFactory = inboxViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
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
