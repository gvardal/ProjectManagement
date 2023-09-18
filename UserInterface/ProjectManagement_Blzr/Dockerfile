#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["UserInterface/ProjectManagement_Blzr/ProjectManagement_Blzr.csproj", "UserInterface/ProjectManagement_Blzr/"]
COPY ["Repositories/Repositories.csproj", "Repositories/"]
COPY ["Entity/Entities/Entities.csproj", "Entity/Entities/"]
RUN dotnet restore "UserInterface/ProjectManagement_Blzr/ProjectManagement_Blzr.csproj"
COPY . .
WORKDIR "/src/UserInterface/ProjectManagement_Blzr"
RUN dotnet build "ProjectManagement_Blzr.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectManagement_Blzr.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectManagement_Blzr.dll"]