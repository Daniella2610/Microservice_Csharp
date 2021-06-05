FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["First_microservice_Csharp/First_microservice_Csharp.csproj", "First_microservice_Csharp/"]
RUN dotnet restore "First_microservice_Csharp/First_microservice_Csharp.csproj"
COPY . .
WORKDIR "/src/First_microservice_Csharp"
RUN dotnet build "First_microservice_Csharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "First_microservice_Csharp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "First_microservice_Csharp.dll"]