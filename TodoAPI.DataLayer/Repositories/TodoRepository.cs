using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Models.DTOs;
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

        public void Delete(Guid TodoId)
        {
            var TodoToDelete = _context.Todos.Where(d => d.Id == TodoId).FirstOrDefault();
            _context.Todos.Remove(TodoToDelete);
            _context.SaveChanges();
        }

        public List<Todo> GetTodos()
        {
            return _context.Todos.ToList();
        }

        public List<Todo> GetTodosForList(Guid ListId)
        {
            return _context.Todos.Where(d => d.TodoListId == ListId).ToList();
        }

        public Todo Update(Guid Id, TodoDTO TodoToUpdate)
        {
            var CurrentTodo = _context.Todos.Where(d => d.Id == Id).FirstOrDefault();
            if(CurrentTodo != null)
            {
                CurrentTodo.TodoListId = TodoToUpdate.TodoListId ?? CurrentTodo.TodoListId;
                CurrentTodo.StatusId = TodoToUpdate.TodoStatusId ?? CurrentTodo.StatusId;
                CurrentTodo.Description = TodoToUpdate.Description ?? CurrentTodo.Description;

                CurrentTodo.LastUpdated = DateTime.Now;

                _context.SaveChanges();
                return CurrentTodo;
            }
            return new Todo();
        }
    }
}
