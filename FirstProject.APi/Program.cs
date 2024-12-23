using FirstProject.Infrastructure;
using FirstProject.Infrastructure.Data;
using FirstProject.Service;
using Microsoft.EntityFrameworkCore;
using FirstProject.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Connection to SQL Server
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));

    
});



#region Dependencies Injections

builder.Services.AddModuleInfrastructureDependencies()
        .AddServiceDependencies()
         .AddModuleCoreDependencies();

//.AddModuleCoreDependencies();

#endregion





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



