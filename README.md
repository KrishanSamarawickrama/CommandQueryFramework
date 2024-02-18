# Project Name: CommandQueryFramework

## Description

CommandQueryFramework is a sample ASP.NET Core application demonstrating the implementation of the Command Query Responsibility Segregation (CQRS) pattern with MediatR. This project serves as an educational tool to showcase best practices in separating command and query responsibilities to achieve a more maintainable and scalable architecture.

## Features

- **CQRS Implementation**: Leverage the CQRS pattern for clear separation of concerns.
- **MediatR Integration**: Utilize MediatR for mediating commands and queries, simplifying business logic.
- **Entity Framework Core**: Use Entity Framework Core for data access and manipulation.
- **In-Memory Database**: Includes an in-memory database setup for easy testing and demonstration.
- **Seed Data Method**: Automated seed data method for initializing the database with sample data.

## Getting Started

These instructions will get your copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET 8 SDK or later
- Visual Studio 2019/2022 or any preferred IDE with C# support

### Installation

1. **Clone the repository**

```bash
git clone https://github.com/KrishanSamarawickrama/CQRSNetArch.git
```

2. **Navigate to the project directory**

```bash
cd CommandQueryFramework
```

3. **Restore NuGet packages**

```bash
dotnet restore
```

4. **Run the application**

```bash
dotnet run --project CommandQueryFramework
```

The application will start on `http://localhost:5072/` by default.

## Usage

Here are some examples of how you can interact with the application:

- **Get all products**

```http
GET /api/products
```

- **Create a new product**

```http
POST /api/products
{
  "name": "New Product",
  "price": 99.99
}
```

## Acknowledgments

- Special thanks to the MediatR library for making CQRS implementations cleaner and more manageable.
- Kudos to Entity Framework Core for simplifying data access in .NET applications.
