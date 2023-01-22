using Microsoft.EntityFrameworkCore;
using PetClinicWebApp.Api.Interfaces;
using PetClinicWebApp.Api.Mappers.CustomerMapper;
using PetClinicWebApp.Api.Persistence;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database / DbContext
// Add services to the container.
var connString = builder.Configuration.GetConnectionString("PetClinicDbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connString);

});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add custom interfaces
builder.Services.AddScoped<ICustomerReadOnlyMapper, CustomerReadOnlyMapper>();

// Add SeriLog
builder.Host.UseSerilog((ctx, lc) =>
    lc.WriteTo.Console()
        .ReadFrom
        .Configuration(ctx.Configuration)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
