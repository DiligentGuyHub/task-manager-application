using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.EntityFramework
{
    public class ToDoDbContextFactory : IDesignTimeDbContextFactory<ToDoDbContext>
    {
        public ToDoDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ToDoDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDo.Database;Trusted_Connection=True;");
            return new ToDoDbContext(options.Options);
        }
    }
}
