using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Enums;

namespace ToDoListAPI.Core.DTO.Task
{
    public class UpdateTaskRequestDTO
    {
       
            [Required(ErrorMessage = "Task ID is required")]
            public Guid Id { get; set; }

            [Required(ErrorMessage = "Title is required")]
            public string Title { get; set; }

            public string? Description { get; set; }

            [Required(ErrorMessage = "Due date is required")]
            public DateTime DueDate { get; set; }

           
            public Status? Status { get; set; }
        
    }
}
