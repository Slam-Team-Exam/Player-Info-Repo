# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Kopiér csproj først for at udnytte Docker cache
COPY *.csproj ./
RUN dotnet restore

# Kopiér resten af koden
COPY . ./

# Publish til en slim mappe
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Kestrel lytter på port 8080 i container
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "PlayerInfoService.dll"]