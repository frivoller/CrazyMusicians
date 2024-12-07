# Crazy Musicians API

A fun and quirky ASP.NET Core Web API that manages a collection of musicians with unique and entertaining traits.

## Features

- Get all musicians
- Search musicians by name
- Get musician by ID
- Create new musician
- Update existing musician
- Delete musician

## Technologies

- ASP.NET Core 8.0
- Swagger/OpenAPI
- Entity Framework Core
- C#

## API Endpoints

### GET Endpoints
- `GET /api/musicians` - Retrieve all musicians
- `GET /api/musicians/search?name={name}` - Search musicians by name
- `GET /api/musicians/{id}` - Get a specific musician by ID

### POST Endpoint
- `POST /api/musicians` - Create a new musician

### PUT Endpoint
- `PUT /api/musicians/{id}` - Update an existing musician

### DELETE Endpoint
- `DELETE /api/musicians/{id}` - Delete a musician

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Build the solution
4. Run the project
5. Navigate to `https://localhost:7139/swagger` to view the Swagger UI

