using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ToDo.Domain.Models
{
    public class AttachedImage : DomainBase
    {
        public byte[] Image { get; set; }
    }
}
