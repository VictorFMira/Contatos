
using Cont.Dominio.Intefaces;
using Cont.Infraestrutura;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

builder.Services.AddDbContext<Contexto>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaltConnection")),
ServiceLifetime.Transient, ServiceLifetime.Transient);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
    x.Lifetime = ServiceLifetime.Transient;
});
