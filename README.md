# BookHub I guess
Eshop for books, that will guess what book you want to read.

## Pre-requisites
- .NET 8.0

## API
- Install dependencies
```sh
dotnet restore
```
- Run the API
```sh
dotnet run --project "API"
```
- Swagger is available at `https://localhost:5174/swagger/index.html`
- API is encrypted with hardcoded Bearer token (that need to be set up in swagger to test the API)

## Database
- We are using SQLITE, may be changed in the future
- Init database
```sh
dotnet ef database update --project "DAL.SQLite.Migrations" --startup-project "Api"
```
- Add migration
```sh
dotnet ef migrations add <Migration-Name> --project "DAL.SQLite.Migrations" --startup-project "Api"
dotnet ef database update --project "DAL.SQLite.Migrations" --startup-project "Api"
```

## Code formatter
The project uses [Csharpier](https://csharpier.com/docs/About).

### Console
To run the formatter in console:
```sh
dotnet csharpier .
```

### Visual Studio
See Csharpier plugin for [Visual Studio](https://marketplace.visualstudio.com/items?itemName=csharpier.CSharpier).

### Rider
See Csharpier plugin for [Rider](https://plugins.jetbrains.com/plugin/18243-csharpier).

## Diagrams
### Entity Relationship Diagram
![ERD](docs/ERD.png)

### Use-case diagram
![UseCaseDiagram](docs/use-case-diagram.png)
