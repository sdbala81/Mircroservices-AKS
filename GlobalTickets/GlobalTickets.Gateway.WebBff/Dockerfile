#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GlobalTickets.Gateway.WebBff/GlobalTickets.Gateway.WebBff.csproj", "GlobalTickets.Gateway.WebBff/"]
COPY ["GlobalTickets.Gateway.Shared/GlobalTickets.Gateway.Shared.csproj", "GlobalTickets.Gateway.Shared/"]
RUN dotnet restore "GlobalTickets.Gateway.WebBff/GlobalTickets.Gateway.WebBff.csproj"
COPY . .
WORKDIR "/src/GlobalTickets.Gateway.WebBff"
RUN dotnet build "GlobalTickets.Gateway.WebBff.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GlobalTickets.Gateway.WebBff.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GlobalTickets.Gateway.WebBff.dll"]