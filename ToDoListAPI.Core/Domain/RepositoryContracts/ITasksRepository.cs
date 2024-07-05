using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.Entities;

namespace ToDoListAPI.Core.Domain.RepositoryContracts
{
    public interface ITasksRepository
    {

        public Task<TodoTask> AddTask(TodoTask task);

        public Task<TodoTask> GetTaskById(Guid id);

        public Task<IEnumerable<TodoTask>> GetTasks();

        public Task<TodoTask> UpdateTask(TodoTask task);

        public Task<bool> DeleteTask(Guid id);

    }
}
