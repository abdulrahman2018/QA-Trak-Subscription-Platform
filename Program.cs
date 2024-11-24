using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using CustomSubscriptionPage; // Replace with your actual project namespace

var builder = WebApplication.CreateBuilder(args);

// Register Syncfusion service (required for Syncfusion components)
builder.Services.AddSyncfusionBlazor();

// Register services for Blazor Server-side app
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Static files, use for images, styles, etc.
app.UseStaticFiles();

// Routing
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
