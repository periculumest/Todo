using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.DataLayer.Models;
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
        public Todo Post([FromBody] Todo newTodo)
        {
            return _todoRepo.Add(newTodo);
        }

        [HttpPut("{id}")]
        public Todo Put(Guid id, [FromBody] Todo todoUpdate)
        {
            return _todoRepo.Update(todoUpdate);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _todoRepo.Delete(id);
        }
    }
}
