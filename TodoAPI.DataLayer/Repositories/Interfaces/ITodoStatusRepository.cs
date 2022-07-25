using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPI.DataLayer.Models;

namespace TodoAPI.DataLayer.Repositories.Interfaces
{
    public interface ITodoStatusRepository
    {
        List<TodoStatus> Get();
    }
}
