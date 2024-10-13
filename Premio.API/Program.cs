using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var anyOrigin = "anyorigin";

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: anyOrigin,
    builder =>
    {
        builder.AllowAnyMethod().AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddControllers();

// Add PostgreSQL support
builder.Services.AddDbContext<PremioDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors(anyOrigin);
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.UseHttpsRedirection();
app.Run();

