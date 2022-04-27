using Kalkulator.AplicationServices.API.Domain;
using Kalkulator.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddMediatR(typeof(ResponseBase<>));
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddDbContext<PaymentsStorageContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PaymentsDatabaseConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



var app = builder.Build();
/*void ConfigureServices(IServiceCollection services)
{
   services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
   services.AddDbContext<PaymentsStorageContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("PaymentsDatabaseConnection")));
}*/

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
