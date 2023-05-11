var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerDocument();

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.UseOpenApi();
app.UseSwaggerUi3();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
