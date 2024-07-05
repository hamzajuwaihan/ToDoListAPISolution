using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListAPI.Core.ServicesContracts
{
    public interface IDeleteTodoTaskService
    {
        public Task<bool> DeleteTask(Guid? id);
    }
}
