using ApiCitas.Data;
using ApiCitas.Data.Repositories;
using ApiCitas.Services;
using Duende.IdentityServer.Models;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Duende.IdentityServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ApiCitas.Services.Identity;

var builder = WebApplication.CreateBuilder(args);

// Agregar IdentityServer
builder.Services.AddIdentityServer()
    .AddInMemoryClients(new List<Duende.IdentityServer.Models.Client>
    {
        new Duende.IdentityServer.Models.Client
        {
            ClientId = "client",
            AllowedGrantTypes = Duende.IdentityServer.Models.GrantTypes.ClientCredentials,
            ClientSecrets =
            {
                new Duende.IdentityServer.Models.Secret("secret".Sha256())
            },
            AllowedScopes = { "ApiCitas" }
        }
    })
    .AddInMemoryApiResources(new List<Duende.IdentityServer.Models.ApiResource>
    {
        new Duende.IdentityServer.Models.ApiResource("ApiCitas", "My API")
        {
            Scopes = { "ApiCitas" }
        }
    });
    

// Añadir el servicio de usuario en memoria
builder.Services.AddSingleton<InMemoryUserService>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IDbContext, DbContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                     .AddEnvironmentVariables();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiCitas", Version = "v1" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);   
    c.IncludeXmlComments(xmlPath);
});

// Agregar servicio de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:4200") // Dominio de tu aplicación Angular
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// **Aqui activa el uso de identity Server
app.UseIdentityServer();

// **Aquí es importante agregar el middleware de CORS antes de Authorization**
app.UseCors("AllowSpecificOrigin");


app.UseAuthorization();

app.MapControllers();

app.Run();
