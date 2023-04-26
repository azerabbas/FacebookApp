using FaceBookApplication.Application.AutoMapper;
using FaceBookApplication.Application.Repositories;
using FaceBookApplication.Persistence.Context;
using FaceBookApplication.Persistence.UnutOfWork;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FacebookContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("FaceBookContext"));
});
builder.Services.AddScoped<IUoW, UoW>();
builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
