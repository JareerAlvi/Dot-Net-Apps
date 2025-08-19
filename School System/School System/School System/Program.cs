using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using School_System.Models;

var builder = WebApplication.CreateBuilder(args);

// Connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register DbContexts
builder.Services.AddDbContext<SchoolManagementSystemContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Register Identity with Roles
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultUI()
.AddDefaultTokenProviders();

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Dashboard}/{id?}");

// Migrate databases and seed roles/users asynchronously
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    // Apply migrations for both contexts
    var identityDbContext = services.GetRequiredService<ApplicationDbContext>();
    await identityDbContext.Database.MigrateAsync();

    var schoolDbContext = services.GetRequiredService<SchoolManagementSystemContext>();
    await schoolDbContext.Database.MigrateAsync();

    // Role and User managers
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

    // Define roles
    string[] roles = { "Admin", "Teacher", "Student", "Parent" };

    // Create roles if they don't exist
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // Create default admin user if not exists
    var adminConfig = builder.Configuration.GetSection("AdminUser");
    var adminEmail = adminConfig["Email"];
    var adminPassword = adminConfig["Password"];
    var adminUser = await userManager.FindByEmailAsync(adminEmail);

    if (adminUser == null)
    {
        var user = new IdentityUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(user, adminPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Admin");
        }
        else
        {
            // Optional: log errors here for admin user creation failure
        }
    }
}

app.Run();
