using Microsoft.EntityFrameworkCore;
using Sales_Management_BLL.Data_transfers_Results.Configurations.Webframework;
using Sales_Management_DAL.Context.Base_Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Insert_Mapster_Configurations();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SalesContext>(configurations =>
{
    configurations.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"));
});

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
