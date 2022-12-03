FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/OmbreAventOfCode.Console/OmbreAventOfCode.Console.csproj", "OmbreAventOfCode.Console/"]
RUN dotnet restore "src/OmbreAventOfCode.Console/OmbreAventOfCode.Console.csproj"
COPY . .
WORKDIR "/src/OmbreAventOfCode.Console"
RUN dotnet build "OmbreAventOfCode.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OmbreAventOfCode.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OmbreAventOfCode.Console.dll"]
