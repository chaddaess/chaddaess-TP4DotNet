using Microsoft.EntityFrameworkCore;
using TP4.Models;
using TP4.Repositories;
using TP4.Services.ServiceContracts;
using TP4.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("default")
));
builder.Services.AddScoped<MovieRepository, MovieRepository>();
builder.Services.AddScoped<GenreRepository, GenreRepository>();
builder.Services.AddScoped<CustomerRepository, CustomerRepository>();
builder.Services.AddScoped<MembershipTypeRepository, MembershipTypeRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IMembershipService, MembershipService>();



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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
