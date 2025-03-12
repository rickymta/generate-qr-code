# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the solution and projects files
COPY WebAPI.sln ./
COPY Library/ ./Library/
COPY WebAPI/ ./WebAPI/

# Restore dependencies
WORKDIR /app/WebAPI
RUN dotnet restore

# Build the service project
RUN dotnet publish -c Release -o /out

# This stage is used to publish the service project to be copied to the final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /out .

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "QRCodeGenerator.dll"]