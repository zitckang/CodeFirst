using CodeFirst.Data;
using CodeFirst.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst
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

            //inject the CodeFirstDBContext to the Services collection
            builder.Services.AddDbContext<CodeFirstDBContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Connectioncodefirst"));
            });

            builder.Services.AddScoped<IRegionRepository, RegionRepository>();

            //Automapper
            //builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); // same with above why

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