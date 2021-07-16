FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Mango.Services.ProductAPI.csproj", "./"]
RUN dotnet restore "Mango.Services.ProductAPI.csproj"
COPY . .
WORKDIR /src
RUN dotnet build "Mango.Services.ProductAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mango.Services.ProductAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mango.Services.ProductAPI.dll"]
