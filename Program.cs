
using DI.API.Repository;
using DI.API.Service;

namespace DI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IAccountService, AccountService>();
            builder.Services.AddTransient<IAccountRepository,AccountRepository>();
            builder.Services.AddTransient<ICardService, CardService>();
            builder.Services.AddTransient<ICardRepository,CardRepository>();
            builder.Services.AddControllers();//AddContoller helps to add all the controller to DI container.
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


            app.MapControllers();//mapping contoller

            app.Run();
        }
    }
}
