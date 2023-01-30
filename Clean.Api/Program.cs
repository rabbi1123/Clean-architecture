using Clean.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration;
Configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddInfrastructure(Configuration);
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
