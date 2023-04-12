using APIBookList.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region  Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "REST API EBOOKLIST",
            Version = "v1",
            Description = "Gerencie liros",
            Contact = new OpenApiContact
            {
                Name = "Jucimario",
                Url = new Uri("https://github.com/jucimario")
            }
        });
});


//Inicio - conexão banco de dados MYSQL
string mySqlConnection = builder.Configuration["ConnectionStrings:MySQLConnectionString"];

builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));

//Fim - conexão banco de dados MYSQL

#endregion


var app = builder.Build();


// Configure the HTTP request pipeline.
#region  Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

#endregion


app.Run();
