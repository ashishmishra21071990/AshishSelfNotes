using Microsoft.EntityFrameworkCore;
using RepositoryPatternMohit.Repository.Contract;
using RepositoryPatternMohit.Repository.Services;
----------------
builder.Services.AddDbContext<EmployeeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IEmployee, EmployeeService>();  // Register your Service Here...
builder.Services.AddScoped<IDepartment, DepartmentService>();
---------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using RepositoryPatternMohit.Repository.Contract;
using RepositoryPatternMohit.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<EmployeeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IEmployee, EmployeeService>();  // Register your Service Here...
builder.Services.AddScoped<IDepartment, DepartmentService>();
var app = builder.Build();

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
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
