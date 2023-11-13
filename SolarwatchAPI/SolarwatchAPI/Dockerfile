FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

#Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=base /app/out .
ENTRYPOINT ["dotnet", "SolarwatchAPI.dll"]