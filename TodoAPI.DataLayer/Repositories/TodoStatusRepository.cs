using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.DataLayer.Repositories
{
    public class TodoStatusRepository : ITodoStatusRepository
    {
        private TodoContext _todoContext;
        public TodoStatusRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }
        public List<TodoStatus> Get()
        {
            return _todoContext.TodoStatuses.ToList();
        }
    }
}
