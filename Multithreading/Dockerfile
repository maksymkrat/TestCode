FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Multithreading/Multithreading.csproj", "Multithreading/"]
RUN dotnet restore "Multithreading/Multithreading.csproj"
COPY . .
WORKDIR "/src/Multithreading"
RUN dotnet build "Multithreading.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Multithreading.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Multithreading.dll"]
