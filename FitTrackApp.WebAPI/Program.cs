using FitTrackApp.WebAPI.Database;
using FitTrackApp.WebAPI.DTOs;
using FitTrackApp.WebAPI.Interfaces;
using FitTrackApp.WebAPI.Security;
using FitTrackApp.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
       {
       new OpenApiSecurityScheme
        {
           Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }},
           new string[]{}
         }
     });
});



/*builder.Services.AddAuthentication("BasicAuthentication")
           .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);*/
builder.Services.AddDbContext<FitTrackContext>(
  options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

builder.Services.AddScoped<IBaseService<ActivityTypeDTO, object>, BaseService<ActivityTypeDTO, object, FitTrackApp.WebAPI.Entities.ActivityType>>();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IActivityService, ActivityService>();
//builder.Services.AddScoped<IActivityTypeService, ActivityTypeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
