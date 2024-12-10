using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Blaga_Teodora_Lab2.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Blaga_Teodora_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Blaga_Teodora_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Blaga_Teodora_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Blaga_Teodora_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Blaga_Teodora_Lab2Context' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
