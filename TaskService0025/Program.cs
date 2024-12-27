using EventBus0025.Interfaces;
using EventBus0025.RabbitMQ;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using TaskService0025.Data;
using TaskService0025.Services;
using TaskService0025.Services.IService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add services to the container.
builder.Services.AddSingleton<IConnection>(sp =>
{
    var factory = new ConnectionFactory
    {
        HostName = "localhost",
        UserName = "guest",
        Password = "guest"
    };
    return factory.CreateConnection();
});
builder.Services.AddSingleton<IEventBus, RabbitMQEventBus>();

// Register Task0025Service
builder.Services.AddScoped<ITaskService0025, Task0025Service>();
builder.Services.AddDbContext<TaskDbContext0025>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITaskService0025, Task0025Service>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
