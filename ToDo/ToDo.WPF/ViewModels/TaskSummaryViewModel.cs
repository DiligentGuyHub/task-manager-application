using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.WPF.State.Tasks;

namespace ToDo.WPF.ViewModels
{
    public class TaskSummaryViewModel : ViewModelBase
    {
        public TaskStore _taskStore;
        public ObservableCollection<TaskViewModel> _tasks;
        public IEnumerable<TaskViewModel> Tasks => _tasks;

        public TaskSummaryViewModel(TaskStore taskStore)
        {
            _taskStore = taskStore;
            _tasks = new ObservableCollection<TaskViewModel>();
            _taskStore.StateChanged += TaskStore_StateChanged;
            ResetTasks();
        }
        private void ResetTasks()
        {
            IEnumerable<TaskViewModel> taskViewModels = _taskStore.Tasks
                .Select(a => new TaskViewModel(a.Header, (DateTime)a.Deadline, a.Category, a.Priority, a.isCompleted, a.Description));
                //.GroupBy(t => t)
                //.Select(g => new TaskViewModel(g.Header, g.Deadline.ToString()));

            _tasks.Clear();
            foreach (TaskViewModel vm in taskViewModels)
            {
                _tasks.Add(vm);
            }
        }

        private void TaskStore_StateChanged()
        {
            OnPropertyChanged(nameof(Tasks));
            ResetTasks();
        }
    }
}
