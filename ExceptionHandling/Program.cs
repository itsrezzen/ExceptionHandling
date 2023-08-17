var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(new DeveloperExceptionPageOptions()
    {
        SourceCodeLineCount = 5
    });
}else if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/exception.html");
}

app.MapGet("/ex", () =>
{
    throw new Exception("Exception Happened !");
});

app.UseStaticFiles();
app.Run();
