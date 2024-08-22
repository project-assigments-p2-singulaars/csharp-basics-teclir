FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ProyectoGuiado2/ProyectoGuiado2.csproj", "ProyectoGuiado2/"]
RUN dotnet restore "ProyectoGuiado2/ProyectoGuiado2.csproj"
COPY . .
WORKDIR "/src/ProyectoGuiado2"
RUN dotnet build "ProyectoGuiado2.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ProyectoGuiado2.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProyectoGuiado2.dll"]
