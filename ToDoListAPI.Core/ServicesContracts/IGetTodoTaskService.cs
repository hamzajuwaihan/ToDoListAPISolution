using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.Entities;

namespace ToDoListAPI.Core.ServicesContracts
{
    public interface IGetTodoTaskService
    {
        public Task<TodoTask> GetTaskById(Guid? id);

        public Task<IEnumerable<TodoTask>> GetTasks();
    }
}
