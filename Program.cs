using GreenswampRazorPages;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<RequestLoggingMiddleware>();

app.UseRouting();

app.UseAuthorization();

app.UseStatusCodePagesWithRedirects("/NotFound");

app.MapRazorPages();

app.Run();