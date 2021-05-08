﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using ToDo.Domain.Services;
using ToDo.WPF.Commands;
using ToDo.WPF.State.Authenticators;

namespace ToDo.WPF.ViewModels
{
    public class TodayViewModel : ViewModelBase
    {
        private ToDo.Domain.Models.Task _selectedTask;
        public ToDo.Domain.Models.Task SelectedTask 
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                _selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }

        private string _task;
        public string Task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                OnPropertyChanged(nameof(Task));
            }
        }

        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        private string _priority;
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }

        public ICommand CreateTaskCommand { get; set; }

        public TodayViewModel(ITaskService taskService, IAuthenticator authenticator)
        {
            CreateTaskCommand = new CreateTaskCommand(this, taskService, authenticator);
            actualDay = DateTime.Now.ToString("dd");
            actualWeekDay = DateTime.Now.ToString("dddd");
            StartTimer();
        }

        private string _actualDay;
        public string actualDay
        {
            get
            {
                return _actualDay;
            }
            set
            {
                _actualDay = value;
                OnPropertyChanged(nameof(actualDay));
            }
        }

        private string _actualWeekDay;
        public string actualWeekDay
        {
            get
            {
                return _actualWeekDay;
            }
            set
            {
                _actualWeekDay = value;
                OnPropertyChanged(nameof(actualWeekDay));
            }
        }

        private DispatcherTimer _timer;
        public DispatcherTimer timer
        {
            get
            {
                return _timer;
            }
            set
            {
                _timer = value;
                OnPropertyChanged(nameof(timer));
            }
        }
        private void StartTimer()
        {
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 1, 0)
            };
            timer.Tick += new EventHandler(GetActualTime);
            timer.Start();
        }
        private void GetActualTime(object sender, EventArgs e)
        {
            actualDay = DateTime.Now.ToString("dd");
            actualWeekDay = DateTime.Now.ToString("dddd");
        }
    }
}
