using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.Commands
{
    public class CreateTaskCommand : ICommand
    {
        private TodayViewModel TodayViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public CreateTaskCommand(TodayViewModel todayViewModel)
        {
            TodayViewModel = todayViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }
    }
}
