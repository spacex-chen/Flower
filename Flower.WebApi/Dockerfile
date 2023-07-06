#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
USER app
WORKDIR /app
EXPOSE 7209

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY ["Flower.WebApi/xFlower.WebApi.csproj", "Flower.WebApi/"]
COPY ["xFlower.Service/xFlower.Service.csproj", "xFlower.Service/"]
COPY ["Flower.Common/xFlower.Common.csproj", "Flower.Common/"]
COPY ["Flower.Model/xFlower.Model.csproj", "Flower.Model/"]
RUN dotnet restore "Flower.WebApi/xFlower.WebApi.csproj"
COPY . .
WORKDIR "/src/Flower.WebApi"
RUN dotnet build "xFlower.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "xFlower.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "xFlower.WebApi.dll"]