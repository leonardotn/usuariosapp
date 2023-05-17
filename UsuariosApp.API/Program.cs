using UsuariosApp.API.Extensions;
using UsuariosApp.Application.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddAutoMapper();
builder.Services.AddServices();

var app = builder.Build();

app.UseSwaggerDoc();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
