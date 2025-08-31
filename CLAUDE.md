# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 8 Blazor Server-Side portfolio application showcasing personal projects, motorcycle interests, book store functionality, and interactive games. The application features a clean separation of concerns with a multi-project solution architecture.

## Development Commands

### Running the Application
```bash
# Run the main UI project
dotnet run --project .\TylorTrub-PortfolioBlazor\

# The application will be available at:
# - HTTPS: https://localhost:7263
# - HTTP: http://localhost:5149
```

### Database Operations
```bash
# Update database with latest migrations
dotnet ef database update --project .\TylorTrub-PortfolioBlazor.Server.BL --startup-project .\TylorTrub-PortfolioBlazor --verbose

# Add new migration
dotnet ef migrations add <MigrationName> --project .\TylorTrub-PortfolioBlazor.Server.BL --startup-project .\TylorTrub-PortfolioBlazor
```

### Building and Publishing
```bash
# Build the entire solution
dotnet build TylorTrubPortfolioBlazor.sln

# Build specific project
dotnet build .\TylorTrub-PortfolioBlazor\TylorTrubPortfolioBlazor.UI.csproj

# Publish for deployment
dotnet publish .\TylorTrub-PortfolioBlazor\TylorTrubPortfolioBlazor.UI.csproj -c Release -o ./publish
```

## Architecture Overview

### Solution Structure
- **TylorTrub-PortfolioBlazor** (UI): Main Blazor Server application with Razor pages and components
- **TylorTrub-PortfolioBlazor.Server.BL**: Business logic layer with Entity Framework, services, and data access
- **TylorTrub-PortfolioBlazor.Client.BL**: Client-side business logic including email services
- **TylorTrub-PortfolioBlazor.DTO**: Data Transfer Objects and models

### Key Technologies
- .NET 8 Blazor Server-Side
- Entity Framework Core 8.0.4 with SQL Server
- ASP.NET Core Identity for authentication
- MudBlazor UI component library
- Fluxor for state management
- Repository pattern with Unit of Work

### Database Context
The `PortfolioDBContext` manages multiple entities:
- Categories, Products (book store functionality)
- Motorcycles, MotorcycleVideos
- PortfolioImages (photo gallery)
- Companies, Games, Projects
- Shopping cart and order management
- Identity tables for user management

### Service Layer
All data access follows the Repository pattern through services implementing interfaces:
- `IPortfolioImagesService`, `IProjectsService`, `IMotorcyclesService`
- `IProductsService`, `IGamesService`, `ICategoriesService`
- Coordinated through `UnitOfWork` pattern

### Component Structure
- **Pages**: Route-based components in `/Pages` folder organized by feature
- **BodyComponents**: Reusable body content components
- **ModelComponents**: Specialized components like `PortfolioImageComponent`
- **Layout**: `MainLayout.razor` with MudBlazor navigation drawer

### Key Features
- Personal portfolio with image gallery and project showcase
- E-commerce functionality (book/motorcycle store)
- Interactive JavaScript games (Hangman, Simon Says)
- Video carousel for motorcycle footage
- Shopping cart and order management
- User authentication and authorization

### Static Assets
- Images organized in `/wwwroot/Images/` by category (home, games, motorcycle, product, project)
- JavaScript files for game functionality and UI interactions
- CSS styling with Bootstrap and MudBlazor theming

## Configuration Notes

- Connection strings configured in `appsettings.json` for different environments
- Identity cookie configuration for login/logout paths
- HTTPS redirection and static file serving configured in `Program.cs`
- MudBlazor services and Fluxor state management registered in DI container