using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddApiVersioning();

            builder.Services.AddApiVersioning(config =>
            {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;

                config.ReportApiVersions = true;
                //config.ApiVersionReader = new MediaTypeApiVersionReader();

                //config.AssumeDefaultVersionWhenUnspecified = true;
                //config.ApiVersionSelector = new CurrentImplementationApiVersionSelector(config);
                //config.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
            });
            builder.Services.AddScoped<Business_Access_Layer.StudentBal>();
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