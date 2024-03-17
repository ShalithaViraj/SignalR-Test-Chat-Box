using chatBox.Hubs;
using chatBox.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ChatService>();
builder.Services.AddSignalR();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:4200"));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<ChatHub>("/hubs/chat");

app.Run();
