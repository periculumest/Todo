using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;

namespace TodoAPI.DataLayer.Repositories.Interfaces
{
    public interface ITodoListRepository
    {
        TodoList Add(TodoList item);
        TodoList Update(TodoList item);
        bool Delete(Guid Id);
        List<TodoList> GetAll();
        TodoList GetById(Guid id);
    }
}
