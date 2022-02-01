# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /TestWebApp

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

WORKDIR "/src/TestWebApp"
COPY . .
RUN dotnet build "TestWebApp.csproj" -c Release -o /out

# Copy everything else and build



# CMD dotnet /Users/zaid/RiderProjects/TestWebApp/TestWebApp/bin/Debug/net5.0/TestWebApp.dll

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /TestWebApp
EXPOSE 80
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "TestWebApp.dll"]