#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the main project file and restore dependencies
COPY ["Hotels/Hotels.csproj", "Hotels/"]
COPY ["Domain/Hotels.Domain.csproj", "Domain/"]
COPY ["Hotels.Application/Hotels.Application.csproj", "Hotels.Application/"]
COPY ["Infrastructure/Hotels.Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "Hotels/Hotels.csproj"

# Copy all necessary project files and directories
COPY . .

# Build the project
RUN dotnet build "Hotels/Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Hotels/Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Create the final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hotels.dll"]













# Use the ASP.NET Core runtime image as the base image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#
## Copy the main project file and restore dependencies
#COPY ["Hotels.csproj", "."]
#RUN dotnet restore "./Hotels.csproj"
#
## Copy all necessary project files and directories
#COPY . .
#
## Ensure the subdirectories are included
#COPY ["./Domain/Hotels.Domain.csproj", "Domain/"]
#COPY ["./Hotels.Application/Hotels.Application.csproj", "Hotels.Application/"]
#COPY ["./Infrastructure/Hotels.Infrastructure.csproj", "Infrastructure/"]
#
## Build the project
#RUN dotnet build "Hotels/Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
## Publish the application
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "Hotels/Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
## Create the final image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Hotels.dll"]












## Use the .NET SDK image for the build stage
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#
## Copy the main project file and restore dependencies
#COPY ["Hotels.csproj", "."]
#RUN dotnet restore "./Hotels.csproj"
#
## Copy all necessary project files and directories
#COPY . .
#
## Ensure the subdirectories are included
#COPY ["Domain/Hotels.Domain.csproj", "Domain/"]
#COPY ["Hotels.Application/Hotels.Application.csproj", "Hotels.Application/"]
#COPY ["Infrastructure/Hotels.Infrastructure.csproj", "Infrastructure/"]
#
#
## Build the project
#RUN dotnet build "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
## Publish the application
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
## Create the final image
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Hotels.dll"]




















## Use the ASP.NET Core runtime image as the base image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
## Use the .NET SDK image for the build stage
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#
## Copy the project file and restore dependencies
#COPY ["Hotels.csproj", "."]
#RUN dotnet restore "./Hotels.csproj"
#
## Copy the rest of the application files
#COPY . .
#WORKDIR "/src"
#RUN dotnet build "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
## Publish the application
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
## Create the final image
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Hotels.dll"]






#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#USER app
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["Hotels/Hotels.csproj", "./"]
#RUN dotnet restore "./Hotels/./Hotels.csproj"
#COPY . .
#WORKDIR "/src/Hotels"
#RUN dotnet build "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./Hotels.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Hotels.dll"]