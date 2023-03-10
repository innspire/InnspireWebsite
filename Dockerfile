#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
EXPOSE 9123

FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src
COPY . ./
RUN dotnet restore "./src/InnspireWebsite.csproj"
WORKDIR "/src/src"
RUN dotnet build "InnspireWebsite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InnspireWebsite.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
RUN addgroup -S netcore && adduser -S netcore -G netcore
USER netcore
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InnspireWebsite.dll"]