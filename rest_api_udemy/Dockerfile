#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["rest_api_udemy/rest_api_udemy.csproj", "rest_api_udemy/"]
RUN dotnet restore "rest_api_udemy/rest_api_udemy.csproj"
COPY . .
WORKDIR "/src/rest_api_udemy"
RUN dotnet build "rest_api_udemy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "rest_api_udemy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "rest_api_udemy.dll"]
