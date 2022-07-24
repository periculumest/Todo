using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataLayer.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int TodoListId { get; set; }
        public int StatusId { get; set; }
        public TodoStatus Status { get; set; } = new TodoStatus();
        public TodoList Parent { get; set; } = new TodoList();
    }
}
