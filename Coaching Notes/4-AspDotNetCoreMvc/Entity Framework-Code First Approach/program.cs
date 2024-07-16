step-5
------------
add services into the container
-----------------------------------
builder.Services.AddDbContext<EmployeeDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
--------------------------------------------------------------------------
after write this service  into the program.cs then  the front of top these two namespace automatically inbuilt
theier name as given below
----------------------
using Microsoft.EntityFrameworkCore;
using WebApplicationcodefirst.Models;