using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);




IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"configuration.{builder.Environment.EnvironmentName.ToLower()}.json", true, true).AddEnvironmentVariables()
                            .Build();

builder.Services.AddOcelot(configuration);

var app = builder.Build();

app.UseOcelot().Wait();


app.Run();
