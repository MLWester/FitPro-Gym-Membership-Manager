using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure the database
var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL") ?? 
    builder.Configuration.GetConnectionString("DefaultConnection");

if (connectionString?.StartsWith("postgres://") == true)
{
    // Parse Heroku connection string
    var uri = new Uri(connectionString);
    var userInfo = uri.UserInfo.Split(':');
    var pgConnectionString = $"Host={uri.Host};Port={uri.Port};Database={uri.AbsolutePath.TrimStart('/')};Username={userInfo[0]};Password={userInfo[1]};SSL Mode=Require;Trust Server Certificate=True";
    
    builder.Services.AddDbContext<FitProDbContext>(options =>
        options.UseNpgsql(pgConnectionString));
}
else
{
    // Use SQLite locally
    builder.Services.AddDbContext<FitProDbContext>(options =>
        options.UseSqlite(connectionString ?? "Data Source=FitProGymManager.db"));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Initialize the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<FitProDbContext>();
        context.Database.Migrate();
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating or seeding the database.");
    }
}

app.Run();
