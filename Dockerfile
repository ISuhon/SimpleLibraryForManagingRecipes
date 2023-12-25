#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Console/ConsoleManagesRecipes/ConsoleManagesRecipes.csproj", "Console/ConsoleManagesRecipes/"]
COPY ["Library/ListOfRecipes/ListOfRecipes.csproj", "Library/ListOfRecipes/"]
COPY ["Library/RecipeManager/RecipeManager.csproj", "Library/RecipeManager/"]
RUN dotnet restore "./Console/ConsoleManagesRecipes/./ConsoleManagesRecipes.csproj"
COPY . .
WORKDIR "/src/Console/ConsoleManagesRecipes"
RUN dotnet build "./ConsoleManagesRecipes.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ConsoleManagesRecipes.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleManagesRecipes.dll"]