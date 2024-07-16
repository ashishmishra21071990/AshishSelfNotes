builder.Services.AddSession(options => { options.IdleTimeout= TimeSpan.FromSeconds(60); });

Add in middleware 
------------------
app.UseSession();// after that this it is available ourself app.UseRouting();

