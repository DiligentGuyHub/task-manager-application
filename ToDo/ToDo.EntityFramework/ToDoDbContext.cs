using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.EntityFramework
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Domain.Models.User> Users { get; set; }
        public DbSet<Domain.Models.Task> Tasks { get; set; }
        public DbSet<Domain.Models.SubTask> SubTasks { get; set; }
        public DbSet<Domain.Models.Category> Categories { get; set; }
        public DbSet<Domain.Models.File> Files { get; set; }
        public DbSet<Domain.Models.Image> Images { get; set; }
    }
}
