using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataLayer.Models.DTOs
{
    public class TodoDTO
    {
        public string? Description { get; set; }
        public Guid? TodoListId { get; set; }
        public Guid? TodoStatusId { get; set; }
    }
}
