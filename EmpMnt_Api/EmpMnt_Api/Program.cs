using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options=> options.UseSqlServer(connection));

builder.Services.AddDbContext<ApplicationDbContext>();
 builder.Services.AddScoped<IEmployeeDal,EmployeeDal>();
  builder.Services.AddScoped<IEmployeeBal,EmployeeBal>();


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
