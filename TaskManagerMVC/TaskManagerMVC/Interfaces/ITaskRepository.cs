using TaskManagerMVC.DTOs;
using TaskManagerMVC.Entities;

namespace TaskManagerMVC.Interfaces
{
    public interface ITaskRepository
    {
        Task Create(TaskEntity task);
        Task<List<TaskEntity>> GetTasks();
    }
}
