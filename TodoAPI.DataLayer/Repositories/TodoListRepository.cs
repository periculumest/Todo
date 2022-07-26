using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.DataLayer.Repositories
{
    public class TodoListRepository : ITodoListRepository
    {
        private TodoContext _context;
        public TodoListRepository(TodoContext Context)
        {
            _context = Context;
        }
        public TodoList Add(TodoList item)
        {
            _context.TodoLists.Add(item);
            _context.SaveChanges();

            return item;
        }

        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<TodoList> GetAll()
        {
            return _context.TodoLists.ToList();
        }

        public TodoList GetById(Guid id)
        {
            return _context.TodoLists.Where(d => d.Id == id).FirstOrDefault();
        }

        public TodoList Update(TodoList item)
        {
            throw new NotImplementedException();
        }
    }
}
