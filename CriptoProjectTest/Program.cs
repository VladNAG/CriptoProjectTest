
using CriptoProjectTest.Data;
using CriptoProjectTest.Interfases;
using CriptoProjectTest.Servises;
using CriptoProjectTest.Entityes;
using NewForReact.Data;
using Microsoft.EntityFrameworkCore;
using CriptoProjectTest.Services;

namespace CriptoProjectTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DataDbContent>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // Add services to the container.
            builder.Services.AddScoped<IAssetService<Asset>, AssetService>();
            builder.Services.AddScoped<IRepository<Asset>, Repository<Asset>>();
            builder.Services.AddScoped<IMyHttpClient, MyHttpClient>();
            builder.Services.AddHostedService<MyBackgroundService>();

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHttpClient();

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            
                app.UseSwagger();
                app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseWebSockets(new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromSeconds(120)
            });

            app.MapControllers();

            app.Run();
        }
    }
}