using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Models.DTOs;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoRepository _todoRepo;
        public TodoController(ITodoRepository todoRepo)
        {
            _todoRepo = todoRepo;
        }

        [HttpGet]
        public List<Todo> Get()
        {
            return _todoRepo.GetTodos();
        }

        [HttpPost]
        public Todo Post([FromBody] TodoDTO Todo)
        {
            var newTodo = new Todo()
            {
                CreatedOn = DateTime.Now,
                Description = Todo.Description,
                Id = Guid.NewGuid(),
                LastUpdated = DateTime.Now,
                StatusId = Todo.TodoStatusId.Value,
                TodoListId = Todo.TodoListId.Value
            };
            
            return _todoRepo.Add(newTodo);
        }

        [HttpPut("{id}")]
        public Todo Put(Guid id, [FromBody] TodoDTO todoUpdate)
        {
            return _todoRepo.Update(id, todoUpdate);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _todoRepo.Delete(id);
        }
    }
}
