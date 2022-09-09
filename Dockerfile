#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KeyholeSoftware.AAfDSignalR.IntegrationEngine.API/KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.csproj", "KeyholeSoftware.AAfDSignalR.IntegrationEngine.API/"]
RUN dotnet restore "KeyholeSoftware.AAfDSignalR.IntegrationEngine.API/KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.csproj"
COPY . .
WORKDIR "/src/KeyholeSoftware.AAfDSignalR.IntegrationEngine.API"
RUN dotnet build "KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.dll"]