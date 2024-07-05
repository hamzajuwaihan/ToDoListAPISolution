using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.Entities;
using ToDoListAPI.Core.Domain.RepositoryContracts;

namespace ToDoListAPI.Infastructure.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        public Task<TodoTask> AddTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTask(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoTask> GetTaskById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoTask>> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Task<TodoTask> UpdateTask(TodoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
