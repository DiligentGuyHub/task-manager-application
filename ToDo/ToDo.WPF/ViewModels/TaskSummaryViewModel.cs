using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.EntityFramework;
using ToDo.WPF.State.Tasks;

namespace ToDo.WPF.ViewModels
{
    public class TaskSummaryViewModel : ViewModelBase
    {
        public TaskStore _taskStore;
        private readonly ToDoDbContextFactory _contextFactory;
        public ObservableCollection<TaskViewModel> _tasks;
        public ObservableCollection<TaskViewModel> Tasks => _tasks;

        public TaskSummaryViewModel(TaskStore taskStore, ToDoDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _taskStore = taskStore;
            _tasks = new ObservableCollection<TaskViewModel>();
            _taskStore.StateChanged += TaskStore_StateChanged;
            ResetTasks();
        }
        private void ResetTasks()
        {
            var taskViewModels = _taskStore.Tasks
                .Select(a => new TaskViewModel(a.Id, a.Header, (DateTime)a.Deadline, a.Category, a.Priority, a.isCompleted, a.Description));
                //.GroupBy(t => t)
                //.Select(g => new TaskViewModel(g.Header, g.Deadline.ToString()));

            _tasks.Clear();
            foreach (TaskViewModel vm in taskViewModels)
            {
                _tasks.Add(vm);
            }
        }

        private void UpdateTask()
        {
            using (ToDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<TaskViewModel> taskViewModels = _taskStore.Tasks
                    .Select(a => new TaskViewModel(a.Id, a.Header, (DateTime)a.Deadline, a.Category, a.Priority, a.isCompleted, a.Description));
                
              
            }
        }

        private void TaskStore_StateChanged()
        {
            OnPropertyChanged(nameof(Tasks));
            OnPropertyChanged(nameof(Task));
            UpdateTask();
            ResetTasks();
        }
    }
}
