FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5116

# Configuração da URL do ASP.NET Core
ENV ASPNETCORE_URLS=http://+:5116

# Executar como usuário 'app' por segurança
USER app

# Imagem do SDK .NET 8.0 para construir o aplicativo
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src

# Copiar o arquivo de projeto e restaurar as dependências
COPY ["src/Ca.Backend.Test.API/Ca.Backend.Test.API.csproj", "src/Ca.Backend.Test.API/"]
RUN dotnet restore "src/Ca.Backend.Test.API/Ca.Backend.Test.API.csproj"

# Copiar todo o código e construir o aplicativo
COPY . .
WORKDIR "/src/src/Ca.Backend.Test.API"
RUN dotnet build "Ca.Backend.Test.API.csproj" -c $configuration -o /app/build

# Fase de publicação
FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Ca.Backend.Test.API.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

# Imagem final com o runtime e o aplicativo publicado
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ca.Backend.Test.API.dll"]
