# syntax=docker/dockerfile:1

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution + csproj files first for better layer caching
COPY TuneVault.sln ./
COPY TuneVault.API/TuneVault.API.csproj TuneVault.API/
COPY TuneVault.Application/TuneVault.Application.csproj TuneVault.Application/
COPY TuneVault.Domain/TuneVault.Domain.csproj TuneVault.Domain/
COPY TuneVault.Infrastructure/TuneVault.Infrastructure.csproj TuneVault.Infrastructure/
COPY TuneVault.Application.Tests/TuneVault.Application.Tests.csproj TuneVault.Application.Tests/ 
# Restore
RUN dotnet restore "TuneVault.sln"

# Copy the rest of the source code
COPY . .

# Publish
RUN dotnet publish "TuneVault.API/TuneVault.API.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish ./

# Container listens on 8080
ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080

ENTRYPOINT ["dotnet", "TuneVault.API.dll"]
