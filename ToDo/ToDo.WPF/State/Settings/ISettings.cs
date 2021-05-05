﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.State.Settings
{
    public enum ThemeType
    {
        Classic,
        Reddish
    }
    public interface ISettings
    {
        public ResourceDictionary CurrentTheme { get; }
        public ICommand UpdateCurrentThemeCommand { get; }
    }
}
