using CAFM.CAFMMappers;
using CAFM.Data;
using CAFM.Repositorio;
using CAFM.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//Config conexion SqlServer

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexionSql"));
});

//Agregar REpositorios
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

//AAgregar AutoMapper

builder.Services.AddAutoMapper(typeof(CAFMMapper));

// Add services to the container.

builder.Services.AddControllers();
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
