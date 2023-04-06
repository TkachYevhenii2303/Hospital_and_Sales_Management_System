using Microsoft.EntityFrameworkCore;
using Students_System.Context;
using Students_System.Repository;
using Students_System.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Set the connection: 
builder.Services.AddDbContext<Students_System_Context>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"));
});

// Inject IRepository in ConfigureServices
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

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
