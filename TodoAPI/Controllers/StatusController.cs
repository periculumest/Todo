using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories.Interfaces;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private ITodoStatusRepository _statusRepo;
        public StatusController(ITodoStatusRepository statusRepo)
        {
            _statusRepo = statusRepo;
        }

        [HttpGet]
        public List<TodoStatus> Get()
        {
            return _statusRepo.Get();
        }
    }
}
