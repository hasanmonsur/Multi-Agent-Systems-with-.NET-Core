using WebApiMultiAgent.Agents;
using WebApiMultiAgent.Interfaces;
using WebApiMultiAgent.Orchestrators;
using WebApiMultiAgent.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddSingleton<KnowledgeBaseService>();

builder.Services.AddSingleton<IAgent, ClassificationAgent>();
builder.Services.AddSingleton<IAgent, ResponseAgent>();

builder.Services.AddSingleton<AgentOrchestrator>();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
