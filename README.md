# ApiCitas

## Descripción

ApiCitas es una API para gestionar citas, implementada en ASP.NET Core. La aplicación sigue las mejores prácticas para la arquitectura de servicios, utilizando inyección de dependencias y patrones de diseño como el Repository Pattern. 

Además, se incluye la documentación para la integración con Swagger, y se han implementado pruebas unitarias con Moq para aislar la lógica de negocio sin afectar la base de datos en las pruebas.

## Características

- CRUD de citas (Crear, Leer, Actualizar, Eliminar)
- Uso de servicios y repositorios con inyección de dependencias
- Integración con Swagger para la documentación de la API
- Pruebas unitarias utilizando Moq para evitar modificaciones en la base de datos durante las pruebas

## Requisitos del sistema

- .NET 6.0 SDK o superior
- SQL Server o cualquier base de datos compatible con Entity Framework Core
- Visual Studio 2022 o Visual Studio Code

## Tecnologías Utilizadas

- ASP.NET Core 6.0
- Entity Framework Core
- Swagger (documentación)
- Moq (pruebas unitarias)
- Xunit (framework de pruebas)

## Instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/felosalgado/Curso-.Net.git
