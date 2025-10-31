using BugStore.Application;
using BugStore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
