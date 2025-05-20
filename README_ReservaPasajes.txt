
# Aplicación de Reserva de Pasajes de Avión

## Descripción General
Esta aplicación de escritorio en C# Windows Forms permite gestionar reservas de vuelos para pasajeros. Está conectada a una base de datos SQL Server y cuenta con funcionalidades diferenciadas por rol (Administrador y Usuario). Aplica principios de POO, patrones de diseño (Singleton, Repository) y una arquitectura organizada.

## Características Implementadas

- **Inicio de sesión con roles (Administrador / Usuario)**
- **CRUD de Vuelos**
- **CRUD de Pasajeros**
- **Conexión a SQL Server (clase Singleton)**
- **Validación de usuarios y redirección por rol**
- **Visualización de reservas por pasajero (en desarrollo)**

## Tecnología
- C# Windows Forms
- SQL Server
- ADO.NET
- Patrones aplicados: Singleton, Repository

## Estructura del Proyecto
- `FormLogin`: Login de usuario.
- `FormAdministrador`: Gestión de vuelos y pasajeros.
- `FormUsuario`: Visualización de reservas personales.
- `Repositories`: Lógica de acceso a datos para Vuelos y Pasajeros.
- `Database.cs`: Clase Singleton para la conexión a SQL Server.
- `Models`: Clases POCO (Vuelo, Pasajero).

## Estado Actual
La aplicación está funcional con login y CRUD de vuelos implementado. El CRUD de pasajeros está en integración y validación.

## Requisitos
- SQL Server con base de datos `ReservaPasajes`
- Usuario con rol administrador o usuario registrado
