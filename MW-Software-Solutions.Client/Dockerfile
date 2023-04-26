FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MW-Software-Solutions.Client/MW-Software-Solutions.Client.csproj", "MW-Software-Solutions.Client/"]
RUN dotnet restore "MW-Software-Solutions.Client/MW-Software-Solutions.Client.csproj"
COPY . .
WORKDIR "/src/MW-Software-Solutions.Client"
RUN dotnet build "MW-Software-Solutions.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MW-Software-Solutions.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MW-Software-Solutions.Client.dll"]
