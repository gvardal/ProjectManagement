#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AuthServer/AuthServerApi/AuthServerApi.csproj", "AuthServer/AuthServerApi/"]
COPY ["AuthServer/AuthServer.Service/AuthServer.Service.csproj", "AuthServer/AuthServer.Service/"]
COPY ["AuthServer/AuthServer.Data/AuthServer.Data.csproj", "AuthServer/AuthServer.Data/"]
COPY ["AuthServer/AuthServer.Core/AuthServer.Core.csproj", "AuthServer/AuthServer.Core/"]
COPY ["AuthServer/SharedLibrary/SharedLibrary.csproj", "AuthServer/SharedLibrary/"]
RUN dotnet restore "AuthServer/AuthServerApi/AuthServerApi.csproj"

COPY . .
WORKDIR "/src/AuthServer/AuthServerApi"
RUN dotnet build "AuthServerApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthServerApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthServerApi.dll"]