
using Microsoft.EntityFrameworkCore;
using Productos.Server.Context;

namespace Productos.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //Variabvle para la cadena de conexión
            var connectionString = builder.Configuration.GetConnectionString("Connection");
            //Registro el servicio para la cadenad de conexion
            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(connectionString)
              );

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
        }
    }
}
