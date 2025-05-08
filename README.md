# TestMinimal

Este es un proyecto minimalista desarrollado en .NET 9.0 que utiliza Entity Framework Core para la gestión de datos y Swashbuckle para la generación de documentación de API.

## Características

- **Entity Framework Core**: Soporte para bases de datos SQLite y SQL Server.
- **Swashbuckle**: Generación automática de documentación de API con Swagger.
- **Estructura Minimalista**: Ideal para aprender o construir aplicaciones pequeñas y rápidas.

## Requisitos Previos

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)
- Un editor de texto o IDE como [Visual Studio Code](https://code.visualstudio.com/)

## Configuración del Proyecto

1. Clona este repositorio:
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   cd TestMinimal
   ```
2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

3. Aplica las migraciones para configurar la base de datos:
   ```bash
   dotnet ef database update
   ```

4. Ejecuta el proyecto:
   ```bash
   dotnet run
   ```

## Estructura del Proyecto

```
TestMinimal/
├── Data/                # Contexto de datos (Entity Framework)
├── Entites/             # Entidades del modelo de datos
├── Migrations/          # Archivos de migración de Entity Framework
├── Properties/          # Configuración del proyecto
├── appsettings.json     # Configuración de la aplicación
├── Program.cs           # Punto de entrada de la aplicación
├── TestMinimal.csproj   # Archivo de configuración del proyecto
```

## Endpoints de la API

La documentación de la API se genera automáticamente con Swagger. Una vez que el proyecto esté en ejecución, puedes acceder a la documentación en:

```
http://localhost:<PUERTO>/swagger
```

## Contribuciones

Si deseas contribuir a este proyecto, por favor sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tu funcionalidad (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -m 'Añadir nueva funcionalidad'`).
4. Haz push a tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia

Este proyecto está bajo la licencia [MIT](LICENSE).