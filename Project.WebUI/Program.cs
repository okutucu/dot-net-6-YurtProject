using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Project.Repository.Context;
using Project.Service.Mapping;
using Project.Service.Validations.RoomValidators;
using Project.WebUI;
using Project.WebUI.Modules;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<RoomDtoValidator>());
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<YurtDbContext>(x =>
{
	x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
	{
		options.MigrationsAssembly(Assembly.GetAssembly(typeof(YurtDbContext)).GetName().Name);

	});
});

builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie( options =>
{
	options.LoginPath = "/Auth/Login";
	options.AccessDeniedPath = "/Auth/AccessDenied";
});

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("SuperAdminPolicy", policy => policy.RequireClaim("role", "SuperAdmin"));
	options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("role", "SuperAdmin", "Admin"));
});


builder.Host.UseServiceProviderFactory
	(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));


var app = builder.Build();

app.UseExceptionHandler("/Home/Error");
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
