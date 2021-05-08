using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.WPF.State.Accounts
{
    public class AccountStore : IAccontStore
    {
        public User CurrentAccount { get; set; }
    }
}
