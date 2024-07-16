builder.Services.AddDbContext<EmployeeDbContext>
	(
	options =>
	{
		options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
	}
	);
builder.Services.AddTransient<EmployeeDbOperation>();
builder.Services.AddTransient<Iemployee,EmployeeServices>();
------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using WebApplicationapi.Contract;
using WebApplicationapi.Models;
using WebApplicationapi.Services;