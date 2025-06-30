# Prueba Técnica Backend

Este proyecto fue desarrollado con **.NET 6**

---

## Requisitos Previos

Antes de ejecutar el proyecto asegurese de tener instalado lo siguiente:

- **.NET 6 SDK:**
    Puede descargarlo desde: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

- **SQL Server**

- **Visual Studio 2022**    

- **EF Core CLI:**
    (En caso de recibir error: dotnet ef no reconocido, instalar: dotnet tool install --global dotnet-ef)

## Ejecutar proyecto

- **Cadena de conexion:**
    En el archivo appsettings.json en la cadena de conexion, reemplazar el nombre de servidor

- **Crear base de datos - actualizar migracion:**
    dotnet ef database update --context PruebaTecnica.Infrastructure.Data.AppDbContext --project PruebaTecnica.Infrastructure --startup-project PruebaTecnica.WebApi