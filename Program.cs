using Microsoft.EntityFrameworkCore;
// Make sure to add a using statement for your Models or Data folder
// e.g., using LensAndLight.Data; 

var builder = WebApplication.CreateBuilder(args);

// 1. REGISTER THE DATABASE CONTEXT
// This tells ASP.NET how to connect to your database using EF Core.
builder.Services.AddDbContext<PhotographyContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. REGISTER RAZOR PAGES
// This service allows the app to find and render your .cshtml files.
builder.Services.AddRazorPages();

var app = builder.Build();

// 3. CONFIGURE THE HTTP REQUEST PIPELINE (Middleware)
// This section handles how the app responds to browser requests.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Required to load Bootstrap, CSS, and Images

app.UseRouting();

app.UseAuthorization();

// 4. MAP THE RAZOR PAGES
// This tells the app to route traffic to your Pages folder.
app.MapRazorPages();

app.Run();