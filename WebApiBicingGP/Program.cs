using MediatR;
using WebApiBicingGP.Manager;

namespace WebApiBicingGP
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

            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Station.Barcelona.StationInputDtoBarcelona).Assembly);
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Station.Paris.StationInputDtoParis).Assembly);
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Station.Rosario.StationInputDtoRosario).Assembly);
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.OpenData.Station.OpenDataStationInputDto).Assembly);
            
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Status.Barcelona.StatusInputDtoBarcelona).Assembly);
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Status.Paris.StatusInputDtoParis).Assembly);
            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.CityBik.Status.Rosario.StatusInputDtoRosario).Assembly);

            builder.Services.AddMediatR(c => c.AsScoped(), typeof(BicingGP.Application.MediatR.MiBiciTuBici.Status.StatusInputDto).Assembly);

            InjectionDependencies(builder);

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

        private static void InjectionDependencies(WebApplicationBuilder builder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                   .AddUserSecrets<Program>()
                                   .Build();
           
            builder.Services.AddSingleton<IConfiguration>(configuration);
            builder.Services.AddSingleton<AppSettings>(new AppSettings(configuration));

            builder.Services.AddSingleton<IDataProviderFactory, DataProviderFactory>();
            builder.Services.AddSingleton<DataProvidersSettings>();

            builder.Services.AddHttpClient();
        }
    }
}