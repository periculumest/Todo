using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataLayer.Models
{
    public class TodoStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();
    }
}
