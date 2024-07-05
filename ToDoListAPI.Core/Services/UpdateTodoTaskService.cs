using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.DTO.Task;
using ToDoListAPI.Core.Enums;
using ToDoListAPI.Core.ServicesContracts;

namespace ToDoListAPI.Core.Services
{
    public class UpdateTodoTaskService : IUpdateTodoTaskService
    {
        private readonly ITasksRepository _taskRepository;

        public UpdateTodoTaskService(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> UpdateTask(UpdateTaskRequestDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
