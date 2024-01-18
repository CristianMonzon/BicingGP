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

            builder.Services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(BicingGPApplication.MediatR.StationMessage).Assembly));                      

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
                                   .Build();
           
            builder.Services.AddSingleton<IConfiguration>(configuration);
            builder.Services.AddSingleton<AppSettings>(new AppSettings(configuration));

            builder.Services.AddHttpClient();
        }
    }
}