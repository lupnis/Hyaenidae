#fin

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Hyaenidae/Hyaenidae.csproj", "Hyaenidae/"]
RUN dotnet restore "Hyaenidae/Hyaenidae.csproj"
COPY . .
WORKDIR "/src/Hyaenidae"
RUN dotnet build "Hyaenidae.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hyaenidae.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hyaenidae.dll"]