FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/MerchandiseService/MerchandiseService.csproj", "src/MerchandiseService/"]
RUN dotnet restore "src/MerchandiseService/MerchandiseService.csproj"
COPY . .
RUN dotnet build "src/MerchandiseService/MerchandiseService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/MerchandiseService/MerchandiseService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MerchandiseService.dll"]
