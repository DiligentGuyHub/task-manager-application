using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDo.Domain.Models;
using ToDo.Domain.Services;
using ToDo.WPF.State.Accounts;
using ToDo.WPF.State.Authenticators;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF.Commands
{
    public class CreateTaskCommand : ICommand
    {
        private readonly ITaskService _taskService;
        private readonly IAccountStore _accountStore;

        private TodayViewModel _todayViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public CreateTaskCommand(TodayViewModel todayViewModel, ITaskService taskService, IAccountStore accountStore)
        {
            _todayViewModel = todayViewModel;
            _taskService = taskService;
            _accountStore = accountStore;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            try
            {
                if(_todayViewModel.Task != "" && _todayViewModel.Category != "" && _todayViewModel.Priority != "")
                {
                    ToDo.Domain.Models.Task task = await _taskService.Create(new ToDo.Domain.Models.Task
                    {
                        UserId = _accountStore.CurrentAccount.Id,
                        Header = _todayViewModel.Task,
                        Priority = _todayViewModel.Priority,
                        Category = _todayViewModel.Category,
                        Description = "",
                        Deadline = DateTime.Now,
                        isCompleted = false,
                        Images = null,
                        Files = null,
                        Subtasks = null
                    });
                    // ???
                    _accountStore.CurrentAccount.Tasks.Append(task);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
