using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Services;

namespace ToDo.EntityFramework.Services.Common
{
    public class TaskDataService : ITaskService
    {
        private readonly ToDoDbContextFactory _contextFactory;
        private readonly NonQueryDataService<ToDo.Domain.Models.Task> _nonQueryDataService;
        public TaskDataService(ToDoDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<ToDo.Domain.Models.Task>(contextFactory);
        }

        public async Task<ToDo.Domain.Models.Task> Create(ToDo.Domain.Models.Task entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }
        public async Task<ToDo.Domain.Models.Task> Update(int id, ToDo.Domain.Models.Task entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }

        public async Task<ToDo.Domain.Models.Task> Get(int id)
        {
            using (ToDoDbContext context = _contextFactory.CreateDbContext())
            {
                // include tasks
                ToDo.Domain.Models.Task entity = await context.Tasks
                    .Include(a => a.Account)
                    .Include(a => a.Images)
                    .Include(a => a.Files)
                    .Include(a => a.Category)
                    .Include(a => a.Subtasks)
                    .FirstOrDefaultAsync((entity) => entity.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<ToDo.Domain.Models.Task>> GetAll()
        {
            using (ToDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<ToDo.Domain.Models.Task> entities = await context.Tasks
                    .Include(a => a.Account)
                    .Include(a => a.Images)
                    .Include(a => a.Files)
                    .Include(a => a.Category)
                    .Include(a => a.Subtasks)
                    .ToListAsync();
                return entities;
            }
        }
    }
}
