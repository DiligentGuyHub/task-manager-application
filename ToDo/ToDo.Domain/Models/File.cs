using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Models
{
    public class File : DomainBase
    {
        public string TaskId { get; set; }
        public File _File { get; set; }

    }
}
