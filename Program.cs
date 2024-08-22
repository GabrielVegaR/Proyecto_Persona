using Microsoft.EntityFrameworkCore;
using Proyecto_Persona.Abstraciones.Repositorios;
using Proyecto_Persona.Abstraciones.Servicios;
using Proyecto_Persona.Implementaciones.Repositorios;
using Proyecto_Persona.Implementaciones.Servicios;
using Proyecto_Persona.Models;

namespace Proyecto_Persona
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<PersonasContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IRepositorioPersona, RepositorioPersona>();
            builder.Services.AddScoped<IServicioPersona, ServicioPersona>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("PermitirTodo",
                    policy =>
                    {
                        policy
                        //.WithOrigins("http://localhost:5173")
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                        //.WithMethods("GET", "POST", "PUT", "PATCH", "DELETE", "OPTIONS");
                        //.WithExposedHeaders("Access-Control-Allow-Origin", "Access-Control-Allow-Headers", "Access-Control-Allow-Methods");

                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("PermitirTodo");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
