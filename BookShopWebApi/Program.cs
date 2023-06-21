using Application;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

using BookShopWebApi.EntityMappers;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("BookShopDb");
builder.Services.AddDbContext<BookShopDbContext>(opt => opt.UseSqlServer(connection, builder => builder.MigrationsAssembly("BookShopWebApi")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddTransient<IBookRepo, BookRepo>();
builder.Services.AddTransient<IClientRepo, ClientRepo>();
builder.Services.AddAutoMapper(typeof(BookShopMapper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
