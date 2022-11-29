using Microsoft.EntityFrameworkCore;

using backendprojects.Models;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NewsapiContext>(option=>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("connection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(option=>option.WithOrigins("*").AllowAnyHeader().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
