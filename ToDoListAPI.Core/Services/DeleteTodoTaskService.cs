using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.ServicesContracts;

namespace ToDoListAPI.Core.Services
{
    public class DeleteTodoTaskService : IDeleteTodoTaskService
    {
        private readonly ITasksRepository _taskRepository;

        public DeleteTodoTaskService(ITasksRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> DeleteTask(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
