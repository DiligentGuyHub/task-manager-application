using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.WPF.State.Settings;
using ToDo.WPF.ViewModels.Factories;

namespace ToDo.WPF.Commands
{
    public class UpdateCurrentThemeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly ISettings _settings;
        private readonly SettingsViewModelFactory _settingsViewModel;

        public UpdateCurrentThemeCommand(ISettings settings, SettingsViewModelFactory settingsViewModel)
        {
            _settings = settings;
            _settingsViewModel = settingsViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int a = 10;
            //App.Current.Resources.MergedDictionaries.Remove
        }
    }
}
