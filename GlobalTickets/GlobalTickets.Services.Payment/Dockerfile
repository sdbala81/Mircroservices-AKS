#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GlobalTickets.Services.Payment/GlobalTickets.Services.Payment.csproj", "GlobalTickets.Services.Payment/"]
COPY ["GlobalTickets.Integration.MessagingBus/GlobalTickets.Integration.MessagingBus.csproj", "GlobalTickets.Integration.MessagingBus/"]
COPY ["GlobalTickets.Integration.Messages/GlobalTickets.Integration.Messages.csproj", "GlobalTickets.Integration.Messages/"]
RUN dotnet restore "GlobalTickets.Services.Payment/GlobalTickets.Services.Payment.csproj"
COPY . .
WORKDIR "/src/GlobalTickets.Services.Payment"
RUN dotnet build "GlobalTickets.Services.Payment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GlobalTickets.Services.Payment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GlobalTickets.Services.Payment.dll"]