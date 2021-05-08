        using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Models
{
    public class Task : DomainBase
    {
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User Account { get; set; }
        public string Header { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; }
        public bool isCompleted { get; set; }
        public IEnumerable<AttachedImage>? Images { get; set; }
        public IEnumerable<AttachedFile>? Files { get; set; }
        public IEnumerable<SubTask>? Subtasks { get; set; } 
    }
}
