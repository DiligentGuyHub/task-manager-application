using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.WPF.State.Settings;

namespace ToDo.WPF.ViewModels.Factories
{
    public class SettingsViewModelFactory : IToDoViewModelFactory<SettingsViewModel>
    {
        private readonly ISettings _settings;

        public SettingsViewModelFactory(ISettings settings)
        {
            _settings = settings;
        }

        public SettingsViewModel CreateViewModel()
        {
            return new SettingsViewModel(_settings);
        }
    }
}
