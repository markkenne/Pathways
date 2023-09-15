//Program.cs

using Microsoft.EntityFrameworkCore;
//using TodoApi.Models;
using RealEstate.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ListingsContext>(opt =>
    opt.UseInMemoryDatabase("ListingsList"));
//opt.UseInMemoryDatabase("TodoList"));
var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();