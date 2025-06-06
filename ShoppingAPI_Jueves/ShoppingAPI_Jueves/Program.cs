using Microsoft.EntityFrameworkCore;
using ShoppingAPI_Jueves.DAL;
using ShoppingAPI_Jueves.Domain.interfaces;
using ShoppingAPI_Jueves.Domain.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//es 
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));

//controlador de dependencias
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddTransient< SeederDB> ();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

SeederData();
void SeederData
{
    IServiceScopeActory? scopedFactory =app.Services.GetService<IServiceScopeFactory>();
    using (IServiceScope? scope = scopedFactory.CreateScope())
{
    SeederDB? service = scope.ServiceProvider.GetService<SeederDB>();
    service.SeederAsync().Wait();
}
}

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
