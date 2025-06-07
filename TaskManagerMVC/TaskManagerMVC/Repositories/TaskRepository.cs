using Microsoft.EntityFrameworkCore;
using TaskManagerMVC.Data;
using TaskManagerMVC.DTOs;
using TaskManagerMVC.Entities;
using TaskManagerMVC.Interfaces;

namespace TaskManagerMVC.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _dbContext;

        public TaskRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Create(TaskEntity task)
        {
            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TaskEntity>> GetTasks()
        {
            var tasks = await _dbContext.Tasks.ToListAsync();
            return tasks;
        }
    }
}
