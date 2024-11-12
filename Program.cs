
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();



var app = builder.Build();

if(app.Environment.IsDevelopment()){
app.UseDeveloperExceptionPage();
}
else{
    app.UseExceptionHandler("/Error");
}



app.UseStaticFiles();
app.UseRouting();
	app.UseEndpoints(x => {
        x.MapRazorPages();
		x.MapControllerRoute(
			name: "Default",
			pattern: "{controller}/{action}",
			defaults: new {Controller = "App", Action = "Index"}
		);
	});

app.Run();
