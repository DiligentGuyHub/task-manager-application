using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDo.WPF.Commands;
using ToDo.WPF.ViewModels;
using ToDo.WPF.ViewModels.Factories;

namespace ToDo.WPF.State.Settings
{
    public class Settings : ViewModelBase, ISettings
    {
        private ResourceDictionary _currentTheme;

        public ResourceDictionary CurrentTheme
        {
            get { return _currentTheme; }
            set
            {
                _currentTheme = value;
                OnPropertyChanged(nameof(CurrentTheme));
            }
        }

        public ICommand UpdateCurrentThemeCommand { get; set; }

        public Settings(SettingsViewModelFactory settingsViewModelFactory)
        {
            UpdateCurrentThemeCommand = new UpdateCurrentThemeCommand(this, settingsViewModelFactory);
        }
    }
}
