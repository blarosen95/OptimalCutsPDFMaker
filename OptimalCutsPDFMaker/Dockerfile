FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OptimalCutsPDFMaker/OptimalCutsPDFMaker.csproj", "OptimalCutsPDFMaker/"]
RUN dotnet restore "OptimalCutsPDFMaker/OptimalCutsPDFMaker.csproj"
COPY . .
WORKDIR "/src/OptimalCutsPDFMaker"
RUN dotnet build "OptimalCutsPDFMaker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OptimalCutsPDFMaker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OptimalCutsPDFMaker.dll"]
