using Hospital_System.Data_transfer_objects.Services_Interfaces;
using Hospital_System.Data_transfer_objects.Services_Interfaces.Interfaces;
using Labs_EF.DataContext;
using Labs_EF.Generator;
using Labs_EF.Repositories;
using Labs_EF.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using Labs_EF.Entities;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(configuration =>
{
    configuration.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Hospital System", 
        Version = "v1" ,
        Description = "API for working with the hospital system."
    });
});

builder.Services.AddDbContext<HospitalContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"), b => b.MigrationsAssembly("Hospital_System"));
});

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Dependency Injections 
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services
    .AddScoped<IUnit_of_Work, Unit_of_Work>()
    .AddScoped<IDoctrosRepository, DoctorsRepository>()
    .AddScoped<IDoctorsServices, DoctorsServices>();


// Set hte configurations for the Identity Server 
builder.Services.AddIdentityCore<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<HospitalContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(configuration =>
    {
        configuration.SwaggerEndpoint("/swagger/v1/swagger.json", "Hospital System");
        configuration.RoutePrefix = string.Empty;
    });
}

app.UseCors("AllowBlazorOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

