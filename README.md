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
2. Navega al directorio del proyecto:


cd Curso-.Net
3. Restaura los paquetes NuGet:
--dotnet restore

4. Configura tu cadena de conexión en el archivo appsettings.json para que apunte a tu base de datos.

5. Ejecuta el proyecto:


--dotnet run

## Uso de Swagger
Una vez que el proyecto esté corriendo, puedes acceder a la documentación de Swagger navegando a la siguiente URL en tu navegador:


-- https://localhost:{puerto}/swagger/index.html
Swagger te permitirá probar los endpoints de la API directamente desde el navegador, además de ver la descripción de cada uno de los métodos disponibles.

## Endpoints Principales
-- GET /api/citas
Obtiene todas las citas registradas en la base de datos.

-- GET /api/citas/{id}
Obtiene una cita específica a partir de su ID.

-- POST /api/citas
Crea una nueva cita.

-- PUT /api/citas/{id}
Actualiza una cita existente.

-- DELETE /api/citas/{id}
Elimina una cita de la base de datos.

## Pruebas Unitarias
El proyecto incluye pruebas unitarias usando el framework xUnit y Moq. Estas pruebas utilizan objetos simulados para evitar cualquier efecto sobre la base de datos en los entornos de pruebas.

-- Ejecutar las pruebas
Para ejecutar las pruebas, utiliza el siguiente comando:


dotnet test
Ejemplos de Pruebas
A continuación se muestra un ejemplo de cómo se prueba el método UpdateCita del controlador CitasController utilizando Moq para simular el servicio de citas:


[Fact]
public async Task UpdateCita_ReturnsNoContentResult_WhenSuccessful()
{
    // Arrange
    var updatedCita = new Cita { CitaID = 1, Descripcion = "Cita actualizada" };
    _mockCitaService.Setup(service => service.UpdateCita(updatedCita)).ReturnsAsync(updatedCita.CitaID);

    // Act
    var result = await _controller.UpdateCita(1, updatedCita);

    // Assert
    Assert.IsType<NoContentResult>(result);
}
