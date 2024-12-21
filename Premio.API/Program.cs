using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Premio.Interfaces;
using Premio.Services;

// Method to seed roles
async Task SeedRoles(IServiceProvider serviceProvider)
{
    using var scope = serviceProvider.CreateScope();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "SA", "Manager", "User" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
            Console.WriteLine($"Role '{role}' created.");
        }
    }
}

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContext<PremioDbContext>(
        options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
    builder.Services.AddAuthentication()
                    .AddBearerToken(IdentityConstants.BearerScheme);
    builder.Services.AddAuthorizationBuilder();
    builder.Services.AddIdentityCore<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<PremioDbContext>()
                    .AddDefaultTokenProviders()
                    .AddApiEndpoints();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // register api services
    builder.Services.AddScoped<IRoleService, RoleService>();


    var app = builder.Build();

    await SeedRoles(app.Services);

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.MapControllers();
    app.Run();
}
catch (Exception e)
{
    Console.WriteLine($"Error while starting the service. Message {e.Message}");
}
