using Microsoft.EntityFrameworkCore;
using Tagpad.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
connectionString = connectionString!.Replace("%PASSWORD%", builder.Configuration["DbPassword"]);
Console.WriteLine("str : " + builder.Configuration["DbPassword"] + "," + connectionString);

builder.Services.AddDbContext<NoteContext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();

//Initialize seed data using scope
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<NoteContext>();
        SeedData.Initialize(context);
    }
    catch (Exception ex)
    {
        // Log any errors during database initialization
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
