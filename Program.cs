using MarkFlixWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<ITautulliService, TautulliService>(c =>
{
    c.BaseAddress = new Uri("http://8fde09ad22a2.sn.mynetname.net:8181/api/v2");
    c.DefaultRequestHeaders.Add("Accept", "application/.json");
});

builder.Services.AddHttpClient<ITheMovieDBService, TheMovieDBService>(c =>
{
    c.BaseAddress = new Uri("https://api.themoviedb.org");
    c.DefaultRequestHeaders.Add("Accept", "application/.json");
});

builder.Services.AddHttpClient<IOverseerrService, OverseerrService>(c =>
{
    c.BaseAddress = new Uri("http://8fde09ad22a2.sn.mynetname.net:5055/api/v1/");
    c.DefaultRequestHeaders.Add("Accept", "application/.json");
    c.DefaultRequestHeaders.Add("X-Api-Key", "MTY0MzA5MjU5Njk1NzIxYmRjZWZiLWIxYWMtNGI1NC1hYzAxLWFhYWJhZjZjOTE1MSk=");
});

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
