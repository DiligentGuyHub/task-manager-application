﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.WPF.Commands;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.State.Navigators
{
    public enum ViewType
    {
        Home,
        Inbox,
        Today,
        Week,
        Month
    }
    public interface INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand { get; }

    }
}
