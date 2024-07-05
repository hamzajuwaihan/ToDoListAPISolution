using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListAPI.Core.Domain.IdentityEntities;
using ToDoListAPI.Core.Enums;

namespace ToDoListAPI.Core.Domain.Entities
{
    public class TodoTask
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; } = Status.Pending;

        [ForeignKey("ApplicationUser")]
        public Guid UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }  // Navigation property

        public TodoTask(string title, string description, DateTime dueDate, Guid userId)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            DueDate = dueDate;
            UserId = userId;  
        }

        // Parameterless constructor needed by EF Core
        public TodoTask() { }
    }

}

