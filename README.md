
````markdown
# 🐾 DjurAPI

Ett enkelt ASP.NET Core Web API-projekt för att hantera en lista med djur.  
Projektet använder en intern minnesdatabas (`DB.cs`) och en `AnimalManager`, inspirerat av Kassaboken-strukturen.

## 📦 API-funktionalitet

- **GET /api/animals**  
  Returnerar alla djur.

- **GET /api/animals/{id}**  
  Returnerar ett specifikt djur baserat på dess ID.

- **POST /api/animals**  
  Lägger till ett nytt djur.

- **PUT /api/animals/{id}**  
  Uppdaterar ett befintligt djur.

- **DELETE /api/animals/{id}**  
  Tar bort ett djur.

## 🧪 Exempeldata

```json
[
  {"id": 1, "species": "Cat", "weight": 4, "flying": false},
  {"id": 2, "species": "Fish", "weight": 2, "flying": false},
  {"id": 3, "species": "Bird", "weight": 1, "flying": true}
]
````

## 🗃️ Projektstruktur

* `Models/Animal.cs` – Djurmodellen
* `DAL/DB.cs` – Innehåller data i minnet
* `DAL/AnimalManager.cs` – Hanterar CRUD-logiken (async)
* `Controllers/AnimalsController.cs` – API-kontrollern

## 🚀 Starta projektet

1. Öppna projektet i Visual Studio.
2. Starta API\:t med `F5` eller `dotnet run`.
3. Testa API\:t med Postman eller via Swagger: `https://localhost:xxxx/swagger`.


