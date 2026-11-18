using Microsoft.EntityFrameworkCore;
using StorageApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StorageContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StorageContext")
        ?? throw new InvalidOperationException("Connection string 'StorageContext' not found.")));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();