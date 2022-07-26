using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Models.DTOs;

namespace TodoAPI.DataLayer.Repositories.Interfaces
{
    public interface ITodoRepository
    {
        List<Todo> GetTodos();
        List<Todo> GetTodosForList(Guid ListId);
        Todo Add(Todo NewTodo);
        Todo Update(Guid Id, TodoDTO TodoToUpdate);
        void Delete(Guid TodoId);
    }
}
