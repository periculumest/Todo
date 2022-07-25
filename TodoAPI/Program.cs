using Microsoft.EntityFrameworkCore;
using TodoAPI.DataLayer.Models;
using TodoAPI.DataLayer.Repositories;
using TodoAPI.DataLayer.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<TodoContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("Todo_conn")));

builder.Services.AddScoped<ITodoListRepository, TodoListRepository>();
//builder.Services.AddScoped<ITodoRepository, TodoRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
