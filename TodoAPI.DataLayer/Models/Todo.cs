using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataLayer.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid TodoListId { get; set; }
        public Guid StatusId { get; set; }
        public TodoStatus Status { get; set; }
        public TodoList Parent { get; set; }
    }
}
