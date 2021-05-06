using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDo.WPF.State.Settings;
using ToDo.WPF.ViewModels;
using ToDo.WPF.ViewModels.Factories;

namespace ToDo.WPF.Commands
{
    public class UpdateCurrentThemeCommand : ICommand
    {
        private readonly ISettings _settings;
        private readonly SettingsViewModel _settingsViewModel;

        public UpdateCurrentThemeCommand(ISettings settings, SettingsViewModel settingsViewModel)
        {
            _settings = settings;
            _settingsViewModel = settingsViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            App.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(
                Application.LoadComponent(new Uri($"/Styles/{parameter.ToString()}.xaml", UriKind.Relative)) as ResourceDictionary
                );
            Application.Current.Resources.MergedDictionaries.Add(
               Application.LoadComponent(new Uri($"/Styles/NavigationBar.xaml", UriKind.Relative)) as ResourceDictionary
               );
            Application.Current.Resources.MergedDictionaries.Add(
               Application.LoadComponent(new Uri($"/Styles/Settings.xaml", UriKind.Relative)) as ResourceDictionary
               );
        }
    }
}
