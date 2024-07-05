using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.DTO.Task;
using ToDoListAPI.Core.ServicesContracts;

namespace ToDoListAPI.Core.Services
{
    public class AddTodoTaskService : IAddTodoTaskService
    {
        private readonly ITasksRepository _taskRepository;

        public AddTodoTaskService(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<TaskResponseDTO> AddTask(AddTaskRequestDTO addTaskRequest)
        {
            throw new NotImplementedException();
        }
    }
}
