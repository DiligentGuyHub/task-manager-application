﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.EntityFramework;
using ToDo.WPF.State.Tasks;

namespace ToDo.WPF.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        private string header;
        public string Header
        {
            get { return header; }
            set
            {
                header = value;
                OnPropertyChanged(nameof(Header));
            }
        }
        public string Category { get; set; }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public string Priority { get; set; }

        private bool iscompleted;
        public bool IsCompleted
        {
            get { return iscompleted; }
            set
            {
                iscompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }

        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set
            {
                deadline = value;
                OnPropertyChanged(nameof(Deadline));
            }
        }
        public string PriorityStatus { get; set; }
        public TaskViewModel(string header, DateTime deadline, string category, string priority, bool iscompleted, string description)
        {
            Header = header;
            Deadline = deadline;
            Category = category;
            Priority = priority;
            IsCompleted = iscompleted;
            Description = description;
            switch (priority)
            {
                case "High":
                    PriorityStatus = "pack://application:,,,/Resources/Icons/priority-high.png";
                    break;
                case "Medium":
                    PriorityStatus = "pack://application:,,,/Resources/Icons/priority-medium.png";
                    break;
                case "Low":
                    PriorityStatus = "pack://application:,,,/Resources/Icons/priority-low.png";
                    break;
                default: break;
            }
        }

    }
}
