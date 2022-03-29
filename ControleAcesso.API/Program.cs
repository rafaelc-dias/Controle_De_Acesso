using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Serviços;
using ControleAcesso.Infraestrutura.Contexto;

using ControleAcesso.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
   //AddNewtonsoftJson(opition => opition.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddDbContext<ControleAcessoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
builder.Services.AddScoped<IPessoaServico, PessoaServico>();

builder.Services.AddScoped<IVeiculoRepositorio, VeiculoRepositorio>();
builder.Services.AddScoped<IVeiculoServico, VeiculoServico>();

builder.Services.AddScoped<IEntradaFuncionarioRepositorio, EntradaFuncionarioRepositorio>();
builder.Services.AddScoped<IEntradaFuncionarioServico, EntradaFuncionarioServico>();

builder.Services.AddScoped<ISaidaCarroEmpresaRepositorio, SaidaCarroEmpresaRepositorio>();
builder.Services.AddScoped<ISaidaCarroEmpresaServico, SaidaCarroEmpresaServico>();

builder.Services.AddScoped<IMovimentoPesagemRepositorio, MovimentoPesagemRepositorio>();
builder.Services.AddScoped<IMovimentoPesagemServico, MovimentoPesagemServico>();

builder.Services.AddScoped<IObservacaoRepositorio, ObservacaoRepositorio>();
//builder.Services.AddScoped<IObservacaoSerivco, ObservacaoServico>();


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
