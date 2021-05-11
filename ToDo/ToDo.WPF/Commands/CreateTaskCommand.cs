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
    public class CreateTaskCommand : AsyncCommandBase
    {
        private ITaskService _taskService;
        private IAccountStore _accountStore;
        private TodayViewModel _todayViewModel;


        public CreateTaskCommand(TodayViewModel todayViewModel, ITaskService taskService, IAccountStore accountStore)
        {
            _todayViewModel = todayViewModel;
            _taskService = taskService;
            _accountStore = accountStore;
        }
        public override async System.Threading.Tasks.Task ExecuteAsync(object parameter)
        {
            try
            {
                
                    //ToDo.Domain.Models.Task task = await _taskService.Create(new ToDo.Domain.Models.Task
                    //{
                    //    UserId = _accountStore.CurrentAccount.Id,
                    //    Header = _todayViewModel.Task,
                    //    Priority = _todayViewModel.Priority,
                    //    Category = _todayViewModel.Category,
                    //    Description = "",
                    //    Deadline = DateTime.Now,
                    //    isCompleted = false,
                    //    Images = null,
                    //    Files = null,
                    //    Subtasks = null
                    //});
                    //// ???
                    //_accountStore.CurrentAccount.Tasks.Append(task);
                    User user = await _taskService.CreateTask(_accountStore.CurrentAccount, _todayViewModel.Task, _todayViewModel.Category, _todayViewModel.Priority);

                    _accountStore.CurrentAccount = user;
                    _todayViewModel.ErrorMessage = "";
            }
            catch (Exception)
            {
                _todayViewModel.ErrorMessage = "All fields must be specified to create a task";
            }
        }
    }
}
