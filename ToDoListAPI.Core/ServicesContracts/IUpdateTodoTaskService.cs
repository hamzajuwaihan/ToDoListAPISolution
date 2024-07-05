using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.DTO.Task;
using ToDoListAPI.Core.Enums;

namespace ToDoListAPI.Core.ServicesContracts
{
    public interface IUpdateTodoTaskService
    {
        public Task<bool> UpdateTask(UpdateTaskRequestDTO request);




    }
}
