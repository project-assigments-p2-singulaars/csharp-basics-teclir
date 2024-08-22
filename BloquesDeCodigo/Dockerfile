FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BloquesDeCodigo/BloquesDeCodigo.csproj", "BloquesDeCodigo/"]
RUN dotnet restore "BloquesDeCodigo/BloquesDeCodigo.csproj"
COPY . .
WORKDIR "/src/BloquesDeCodigo"
RUN dotnet build "BloquesDeCodigo.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BloquesDeCodigo.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BloquesDeCodigo.dll"]
