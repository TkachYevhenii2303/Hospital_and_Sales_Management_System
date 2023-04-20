using Labs_EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Sales_Management_BLL.Data_transfers_Results.Configurations.Webframework;
using Sales_Management_BLL.Data_transfers_Results.Services_Results;
using Sales_Management_DAL.Context.Base_Context;
using Sales_Management_DAL.Repositories;
using Sales_Management_DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Insert_Mapster_Configurations();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SalesContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"), 
        options => options.MigrationsAssembly("Sales_Managament_Migrations"));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnit_of_Work, Unit_of_Work>();
builder.Services.AddScoped<ICustomersServices, CustomerServices>();

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
