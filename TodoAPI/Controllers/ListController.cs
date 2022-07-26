using Microsoft.AspNetCore.Mvc;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private ITodoListRepository _todoListRepo;
        private ITodoRepository _todoRepo;
        public ListController(ITodoListRepository todoListRepo, ITodoRepository todoRepo)
        {
            _todoListRepo = todoListRepo;
            _todoRepo = todoRepo;
        }
        [HttpGet]
        public List<TodoList> Get()
        {
            return _todoListRepo.GetAll();
        }

        [HttpPost]
        public TodoList Add([FromBody] string Description)
        {
            return _todoListRepo.Add(new TodoList()
            {
                CreatedOn = DateTime.Now,
                Id = Guid.NewGuid(),
                UpdatedOn = DateTime.Now,
                Title = Description
            });
        }

        [HttpGet("{id}/todos")]
        public List<Todo> GetTodos(Guid id)
        {
            return _todoRepo.GetTodosForList(id);
        }

        [HttpGet("{id}")]
        public TodoList Get(Guid id)
        {
            return _todoListRepo.GetById(id);
        }
    }
}
