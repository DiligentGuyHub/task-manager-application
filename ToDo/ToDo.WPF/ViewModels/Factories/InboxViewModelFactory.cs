using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WPF.ViewModels.Factories
{
    public class InboxViewModelFactory : IToDoViewModelFactory<InboxViewModel>
    {
        public InboxViewModel CreateViewModel()
        {
            return new InboxViewModel();
        }
    }
}
