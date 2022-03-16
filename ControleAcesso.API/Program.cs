using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Serviços;
using ControleAcesso.Infraestrutura.Contexto;

using ControleAcesso.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ControleAcessoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPessoasRepositorio, PessoasRepositorio>();
builder.Services.AddScoped<IPessoasServico, PessoasServico>();

builder.Services.AddScoped<IVeiculosRepositorio, VeiculosRepositorio>();
builder.Services.AddScoped<IVeiculosServico, VeiculosServico>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
