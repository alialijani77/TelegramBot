using Microsoft.Extensions.DependencyInjection;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.TelegramBot_Api>("apiservice");

builder.Build().Run();
