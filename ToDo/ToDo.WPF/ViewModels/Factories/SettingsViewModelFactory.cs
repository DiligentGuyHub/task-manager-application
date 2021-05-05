using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WPF.ViewModels.Factories
{
    public class SettingsViewModelFactory : IToDoViewModelFactory<SettingsViewModel>
    {
        public SettingsViewModel CreateViewModel()
        {
            return new SettingsViewModel();
        }
    }
}
