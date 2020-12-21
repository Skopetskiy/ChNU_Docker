FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80/tcp

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src

COPY ["smart-home-web/smart-home-web.csproj", "smart-home-web/"]
COPY ["Infrastructure.Business/Infrastructure.Business.csproj", "Infrastructure.Business/"]
COPY ["Domain.Core/Domain.Core.csproj", "Domain.Core/"]
COPY ["Domain.Interfaces/Domain.Interfaces.csproj", "Domain.Interfaces/"]
COPY ["Infrastructure.Data/Infrastructure.Data.csproj", "Infrastructure.Data/"]
RUN dotnet restore "smart-home-web/smart-home-web.csproj"
COPY . .
WORKDIR "/src/smart-home-web"
RUN dotnet build "smart-home-web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "smart-home-web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
