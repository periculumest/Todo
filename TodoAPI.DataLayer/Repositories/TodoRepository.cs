using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.DataLayer.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }
        public Todo Add(Todo NewTodo)
        {
            NewTodo.CreatedOn = DateTime.Now;
            NewTodo.LastUpdated = DateTime.Now;
            NewTodo.Id = Guid.NewGuid();

            _context.Todos.Add(NewTodo);
            _context.SaveChanges();

            return NewTodo;
        }

        public bool Delete(int TodoId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid TodoId)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetTodos()
        {
            return _context.Todos.ToList();
        }

        public List<Todo> GetTodosForList(Guid ListId)
        {
            throw new NotImplementedException();
        }

        public Todo Update(Todo TodoToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
