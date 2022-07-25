using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAPI.DataLayer.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<TodoStatus> TodoStatuses { get; set; }
        public string DbPath { get; }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)  
        {

        }
    }
}
