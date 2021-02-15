#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AutoShopping/AutoShopping.csproj", "AutoShopping/"]
RUN dotnet restore "AutoShopping/AutoShopping.csproj"
COPY . .
WORKDIR "/src/AutoShopping"
RUN dotnet build "AutoShopping.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoShopping.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoShopping.dll"]