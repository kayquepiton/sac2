using System.Reflection;
using Sac.Backend.Login.IoC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
ConfigureMiddleware(app);

app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    // Adiciona páginas Razor ao contêiner de serviços
    services.AddRazorPages();

    // Adiciona controladores ao contêiner de serviços
    services.AddControllers();

    // Configura opções de comportamento da API
    services.Configure<ApiBehaviorOptions>(options =>
    {
        options.SuppressModelStateInvalidFilter = true; // Suprime a validação automática do estado do modelo
    });

    // Adiciona serviços para exploração de endpoints da API e configuração do Swagger/OpenAPI
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "SAC LOGIN API .NET8 (Base)",
            Version = "v1",
            Description = "Este projeto é uma API REST desenvolvida em .NET 8.0 para SAC LOGIN.",
        });

        // Configura comentários XML para o Swagger
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });

    // Configura dependências da aplicação
    services.ConfigureAppDependencies(configuration);

    // Adiciona HttpClient ao contêiner
    services.AddHttpClient();
}

void ConfigureMiddleware(WebApplication app)
{
    // Habilita Swagger no ambiente de desenvolvimento
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.RoutePrefix = string.Empty; // Define a UI do Swagger na raiz do aplicativo
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "SAC LOGIN Management API .NET8 (Base)");
        });
    }
    else
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    // Redireciona solicitações HTTP para HTTPS
    app.UseHttpsRedirection();

    // Habilita arquivos estáticos
    app.UseStaticFiles();

    // Adiciona middleware de roteamento
    app.UseRouting();

    // Adiciona middleware de autorização
    app.UseAuthorization();

    // Mapeia controladores roteados por atributos
    app.MapControllers();

    // Mapeia páginas Razor
    app.MapRazorPages();
}

