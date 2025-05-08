using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TestMinimal.Data;
using TestMinimal.Entites;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Date Base
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Demo Minimal API",
        Description = "A simple example of a minimal API using ASP.NET Core",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Leonard Gonzalez",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "ASP .NET Core License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();

// Config Swagger in  pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");
app.MapPost("/person", async (Person person, DataContext context) =>
{
    context.Persons.Add(person);
    await context.SaveChangesAsync();
    return Results.Ok(person);
});
app.MapGet("/person", async (DataContext context) =>
{
    var persons = await context.Persons.ToListAsync();
    return Results.Ok(persons);
});
app.MapGet("/person/{id}", async (int id, DataContext context) =>
{
    var person = await context.Persons.FindAsync(id);
    if (person == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(person);
});
app.MapPut("/person/{id}", async (int id, Person person, DataContext context) =>
{
    var existingPerson = await context.Persons.FindAsync(id);
if (existingPerson == null)
{
    return Results.NotFound("Person not found");
    }
    existingPerson.Name = person.Name;
    existingPerson.LastName = person.LastName;
    existingPerson.Age = person.Age;
    await context.SaveChangesAsync();
    return Results.Ok(existingPerson);
});

app.Run();
