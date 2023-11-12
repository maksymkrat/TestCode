FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Task/Task.csproj", "Task/"]
RUN dotnet restore "Task/Task.csproj"
COPY . .
WORKDIR "/src/Task"
RUN dotnet build "Task.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task.dll"]
