using CloudDbTest.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/all", async (ApplicationDbContext db) =>
{
    return await db.ExampleTable.ToArrayAsync();

});

app.MapGet("/findbyid", async (ApplicationDbContext db, ExampleTable id) =>
{
    List<ExampleTable> Ids = db.ExampleTable.ToList();
    return Ids.Find(x => x.Id == id.Id);

});

app.MapPost("/add", async (ExampleTable data, ApplicationDbContext db) =>
{
    db.ExampleTable.Add(data);
    await db.SaveChangesAsync();
    return data;
});

app.Run();
