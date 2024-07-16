using Business_Access_Layer.Contract;//second step-automatically insert
using Business_Access_Layer.Services;//second step-automatically insert
using Common_Layer;//first step-automatically insert


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
DbConnectionconfigcs.ConnectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");// when i used this in the front of top namespace automatically add -first step
builder.Services.AddTransient<Iemployee,Employeeservice>();// when i used this in the front of top 2 namespace automatically add -second step