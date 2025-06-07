using TaskManagerMVC.DTOs;
using TaskManagerMVC.Entities;
using TaskManagerMVC.Interfaces;

namespace TaskManagerMVC.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;
        }

        public async Task Create(TaskCreateDTO task)
        {
            TaskEntity newTask = new TaskEntity() 
            { 
                Titulo = task.Titulo,
                Assunto = task.Assunto,
                Descricao = task.Descricao,
                Prioridade = task.Prioridade
            };

            await _taskRepository.Create(newTask);
        }

        public async Task<List<TaskGetDTO>> GetTasks()
        {
            List<TaskGetDTO> tasks = new List<TaskGetDTO>();

            try
            {
                var taskList = await _taskRepository.GetTasks();

                foreach (var task in taskList)
                {
                    tasks.Add(
                        new TaskGetDTO
                        {
                            ID = task.ID,
                            Titulo = task.Titulo,
                            Assunto = task.Assunto,
                            Descricao = task.Descricao,
                            Prioridade = task.Prioridade
                        }
                     );       
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tasks;
        }
    }
}
