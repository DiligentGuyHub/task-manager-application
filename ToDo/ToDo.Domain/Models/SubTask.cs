using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Models
{
    public class SubTask : DomainBase
    {
        public string TaskId { get; set; }
        public string Header { get; set; }
        public bool isCompleted { get; set; }

    }
}
