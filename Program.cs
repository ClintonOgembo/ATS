using AttainTaskSupportSystem.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AttainTaskSupportSystem.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<AttainTaskSupportSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AttainTaskSupportSystemContext") ?? throw new InvalidOperationException("Connection string 'AttainTaskSupportSystemContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

app.MapRazorPages();

app.MapBlazorHub();


