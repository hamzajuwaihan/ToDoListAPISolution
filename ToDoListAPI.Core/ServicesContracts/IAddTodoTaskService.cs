using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.RepositoryContracts;
using ToDoListAPI.Core.DTO.Task;

namespace ToDoListAPI.Core.ServicesContracts
{
    public interface IAddTodoTaskService
    {
 
        public Task<TaskResponseDTO> AddTask(AddTaskRequestDTO addTaskRequest);
        
        

    }
}
