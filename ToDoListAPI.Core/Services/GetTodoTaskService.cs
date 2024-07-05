using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.Entities;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.ServicesContracts;

namespace ToDoListAPI.Core.Services
{
    public class GetTodoTaskService : IGetTodoTaskService
    {
        private readonly ITasksRepository _taskRepository;


        public GetTodoTaskService(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TodoTask> GetTaskById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoTask>> GetTasks()
        {
            throw new NotImplementedException();
        }
    }
}
