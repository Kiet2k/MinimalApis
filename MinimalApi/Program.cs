using Microsoft.EntityFrameworkCore;
using MinimalApi.Contexts;
using MinimalApi.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SimpleFaceBookDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("api/posts", async (SimpleFaceBookDbContext db) => await db.Posts.ToListAsync());

app.MapPost("api/create", async (SimpleFaceBookDbContext db, Post post)=>
    {
    await db.Posts.AddAsync(post);
      await  db.SaveChangesAsync();
        return Results.Ok(post);
});

app.Run();
