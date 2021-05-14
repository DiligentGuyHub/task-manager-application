using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;
using ToDo.Domain.Services;

namespace ToDo.EntityFramework.Services.Common
{
    public class TaskDataService : ITaskService
    {
        private readonly ToDoDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Domain.Models.Task> _nonQueryDataService;

        public TaskDataService(ToDoDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<Domain.Models.Task>(contextFactory);
        }

        public async Task<Domain.Models.Task> Create(Domain.Models.Task entity)
        {
            return await _nonQueryDataService.Create(entity);
        }
        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }
        public async Task<Domain.Models.Task> Update(int id, Domain.Models.Task entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
        public async Task<Domain.Models.Task> Get(int id)
        {
            using (ToDoDbContext context = _contextFactory.CreateDbContext())
            {
                // include tasks
                Domain.Models.Task entity = await context.Tasks
                    .Include(a => a.Subtasks)
                    .Include(a => a.Images)
                    .Include(a => a.Files)
                    .FirstOrDefaultAsync((entity) => entity.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Domain.Models.Task>> GetAll()
        {
            using (ToDoDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Domain.Models.Task> entities = await context.Tasks
                    .Include(a => a.Subtasks)
                    .Include(a => a.Images)
                    .Include(a => a.Files)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<User> CreateTask(User account, string header, string category, string priority)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateTask(User account)
        {
            throw new NotImplementedException();
        }

        //public async Task<User> CreateTask(User account, string header, string category, string priority)
        //{
        //    if (!string.IsNullOrEmpty(header) &&
        //        !string.IsNullOrEmpty(category) &&
        //        !string.IsNullOrEmpty(priority))
        //    {
        //        Domain.Models.Task task = new Domain.Models.Task()
        //        {
        //            Account = account,
        //            Header = header,
        //            Category = category,
        //            Priority = priority,
        //            Description = "",
        //            Deadline = DateTime.Now,
        //            isCompleted = false,
        //            Images = null,
        //            Files = null,
        //            Subtasks = null
        //        };


        //        account.Tasks.Add(task);
        //    }
        //    await _accountService.Update(account.Id, account);
        //    return account;
        //}
        //public async Task<User> UpdateTask(User account)
        //{
        //    await _accountService.Update(account.Id, account);
        //    return account;
        //}
    }
}
