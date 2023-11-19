using ErpTranscript.Models;
using ErpTranscript.Security;
using ErpTranscript.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequiredPermissions",
        policy => policy.AddRequirements(new ManagePermissionsRequirement()));
});

builder.Services.AddScoped<ProcessTranscript>();

builder.Services.AddScoped<NumberToWordsConverter>();

builder.Services.AddDbContext<TranscriptDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TranscriptDbContext")));

builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbContext")));

builder.Services.AddDbContext<YabaResOnlineDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("YabaResOnlineDbContext")));

builder.Services.AddSingleton<IAuthorizationHandler, AccessPageHandler>();

builder.Services.AddHttpClient("AppHttpClient");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
