using TaskManagerMVC.DTOs;

namespace TaskManagerMVC.Interfaces
{
    public interface ITaskService
    {
        Task Create(TaskCreateDTO task);
        Task<List<TaskGetDTO>> GetTasks();
    }
}
