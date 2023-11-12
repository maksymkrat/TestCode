FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NullGuard/NullGuard.csproj", "NullGuard/"]
RUN dotnet restore "NullGuard/NullGuard.csproj"
COPY . .
WORKDIR "/src/NullGuard"
RUN dotnet build "NullGuard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NullGuard.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NullGuard.dll"]
