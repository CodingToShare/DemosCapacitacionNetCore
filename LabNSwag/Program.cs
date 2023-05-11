var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSwaggerDocument(options =>
{
    options.PostProcess = document =>
    {
        document.Info.Version = "v1";
    };
});
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseOpenApi();
app.UseSwaggerUi3();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
