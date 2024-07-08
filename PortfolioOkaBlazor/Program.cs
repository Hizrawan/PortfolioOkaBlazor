using Microsoft.AspNetCore.Components.Web;
using PortfolioOkaBlazor.Components;
using Microsoft.AspNetCore.Components;
using PortfolioOkaBlazor.Persistence;
using System.Reflection;
using MediatR;
using PortfolioOkaBlazor.Features.Educations.Queries.Get;
using PortfolioOkaBlazor.Features.Educations.Queries.List;
using PortfolioOkaBlazor.Features.Educations.Commands.Create;
using PortfolioOkaBlazor.Features.Educations.Commands.Delete;
using PortfolioOkaBlazor.Features.Educations.Commands.Update;
using PortfolioOkaBlazor.Features.WorkExperiences.Queries.Get;
using PortfolioOkaBlazor.Features.WorkExperiences.Queries.List;
using PortfolioOkaBlazor.Features.WorkExperiences.Commands.Create;
using PortfolioOkaBlazor.Features.WorkExperiences.Commands.Delete;
using PortfolioOkaBlazor.Features.WorkExperiences.Commands.Update;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();
builder.Services.AddSingleton<IWebHostEnvironment>(builder.Environment);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddScoped(sp =>
{
    var navigationManager = sp.GetRequiredService<NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(navigationManager.BaseUri) };
});

var app = builder.Build();

app.MapGet("/Educations/{id:guid}", async (Guid id, ISender mediatr) =>
{
    var Education = await mediatr.Send(new GetEducationQuery(id));
    if (Education == null) return Results.NotFound();
    return Results.Ok(Education);
});

app.MapGet("/Educations", async (ISender mediatr) =>
{
    var Educations = await mediatr.Send(new ListEducationsQuery());
    return Results.Ok(Educations);
});

app.MapPost("/Educations", async (CreateEducationCommand command, ISender mediatr) =>
{
    var EducationId = await mediatr.Send(command);
    if (Guid.Empty == EducationId) return Results.BadRequest();
    return Results.Created($"/Educations/{EducationId}", new { id = EducationId });
});

app.MapDelete("/Educations/{id:guid}", async (Guid id, ISender mediatr) =>
{
    await mediatr.Send(new DeleteEducationCommand(id));
    return Results.NoContent();
});

app.MapGet("/WorkExperiences/{id:guid}", async (Guid id, ISender mediatr) =>
{
    var WorkExperience = await mediatr.Send(new GetWorkExperiencesQuery(id));
    if (WorkExperience == null) return Results.NotFound();
    return Results.Ok(WorkExperience);
});

app.MapGet("/WorkExperiences", async (ISender mediatr) =>
{
    var WorkExperiences = await mediatr.Send(new ListWorkExperiencesQuery());
    return Results.Ok(WorkExperiences);
});

app.MapPost("/WorkExperiences", async (CreateWorkExperienceCommand command, ISender mediatr) =>
{
    var WorkExperienceId = await mediatr.Send(command);
    if (Guid.Empty == WorkExperienceId) return Results.BadRequest();
    return Results.Created($"/WorkExperiences/{WorkExperienceId}", new { id = WorkExperienceId });
});

app.MapDelete("/WorkExperiences/{id:guid}", async (Guid id, ISender mediatr) =>
{
    await mediatr.Send(new DeleteWorkExperienceCommand(id));
    return Results.NoContent();
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for Educationion scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


