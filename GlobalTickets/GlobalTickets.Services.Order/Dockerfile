#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GlobalTickets.Services.Order/GlobalTickets.Services.Ordering.csproj", "GlobalTickets.Services.Order/"]
COPY ["GlobalTickets.Integration.Messages/GlobalTickets.Integration.Messages.csproj", "GlobalTickets.Integration.Messages/"]
COPY ["GlobalTickets.Integration.MessagingBus/GlobalTickets.Integration.MessagingBus.csproj", "GlobalTickets.Integration.MessagingBus/"]
RUN dotnet restore "GlobalTickets.Services.Order/GlobalTickets.Services.Ordering.csproj"
COPY . .
WORKDIR "/src/GlobalTickets.Services.Order"
RUN dotnet build "GlobalTickets.Services.Ordering.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GlobalTickets.Services.Ordering.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GlobalTickets.Services.Ordering.dll"]