# ReservaVuelo ✈️

Aplicación de escritorio en C# (Windows Forms) que permite la gestión de vuelos, reservas, pagos y usuarios con control por roles (Administrador y Usuario), utilizando SQL Server como base de datos. 

---

## 🧩 Estructura del Proyecto

ReservaVuelo/
│
├── Database/
│ └── Database.cs # Singleton de conexión a SQL Server
│
├── Models/
│ ├── Vuelo.cs
│ ├── Pasajero.cs
│ ├── Usuario.cs
│ ├── ReservaDetalle.cs
│ └── Pago.cs
│
├── Repositories/
│ ├── VueloRepository.cs
│ ├── PasajeroRepository.cs
│ ├── UsuarioRepository.cs
│ ├── ReservaRepository.cs
│ └── PagoRepository.cs
│
├── Forms/
│ ├── FormLogin.cs
│ ├── FormAdministrador.cs
│ ├── FormUsuario.cs
│ ├── FormReservarVuelo.cs
│ ├── FormPasajeros.cs
│ └── FormPagos.cs
│
├── App.config # Configuración de la cadena de conexión
├── Program.cs # Entry point
└── README.md # Este documento


## 🛠️ Tecnologías y Arquitectura

- **Lenguaje**: C# (.NET Framework)
- **Interfaz**: Windows Forms
- **Base de datos**: SQL Server
- **Estilo de arquitectura**: Capas (Models, Repositories, Forms)

### 🧠 Patrones y Principios Aplicados

| Patrón / Principio | Aplicación |
|--------------------|------------|
| **Repository**     | Encapsula el acceso a datos (CRUD) desde las clases `*Repository.cs`. Permite separar lógica de negocio de la capa de presentación. |
| **Singleton**      | Clase `Database.Instance` controla una única conexión activa a SQL Server. |
| **SOLID**          | Se aplicó el principio de responsabilidad única en las capas y clases, separando cada responsabilidad. |
| **Encapsulamiento**| La lógica de asignación de asientos, validación de pagos y cancelaciones están aisladas en métodos específicos. |

---

## 👤 Manual Básico de Usuario

### 👨‍✈️ Para Administradores

1. **Inicio de sesión** con credenciales de administrador.
2. **Gestión de vuelos**:
   - Agregar, actualizar, eliminar vuelos.
   - Validación de duplicados (`Número de vuelo`).
3. **Gestión de pasajeros**:
   - Crear nuevos usuarios/pasajeros.
   - Actualizar datos personales y claves.
   - Eliminar usuarios y sus reservas asociadas.
4. **Visualización de reportes**:
   - Vuelos más populares.
   - Ocupación por destino y estado.

### 🙋 Para Usuarios

1. **Registro**: Puede ser creado por el administrador.
2. **Inicio de sesión** como usuario.
3. **Reservar vuelo**:
   - Selecciona vuelo disponible.
   - Asiento se asigna automáticamente.
   - Se muestra origen, destino, precio y fecha.
4. **Pagos**:
   - Puede realizar pagos parciales o totales.
   - Ver saldo pendiente en tiempo real.
   - Recibe alertas de pagos pendientes.
5. **Cancelar reserva**:
   - Cambia el estado a "Cancelada".
   - Libera el asiento y actualiza disponibilidad del vuelo.

---

## 🧪 Casos especiales gestionados

- ❌ No se permite reservar si no hay asientos disponibles.
- ✅ Cancelar reserva reestablece la disponibilidad del vuelo.
- 📬 Se generan notificaciones si hay saldo pendiente.
- 🧾 Pagos se registran con su método, fecha y saldo actualizado.
- 🔐 Control de acceso basado en roles ("Administrador" o "Usuario").

---

## 🔧 Requisitos

- Visual Studio 2019 o superior.
- SQL Server (Express o completo).
- .NET Framework 4.7 o superior.

---

## 🧩 Instalación

1. Clonar el repositorio.
2. Restaurar paquetes NuGet si aplica.
3. Crear base de datos `ReservaPasajes` en SQL Server.
4. Ejecutar los scripts `CREATE TABLE`, índices y procedimientos almacenados.
5. Configurar `App.config` con la cadena de conexión adecuada.
6. Ejecutar la aplicación desde `Program.cs`.

---

## 📂 Scripts incluidos

- `SP_RegistrarReserva`
- `SP_RegistrarPagoReserva`
- `SP_CancelarReserva`
- `SP_GenerarReporteOcupacionVuelos`
- `SP_NotificarCambioVuelo`

---

## 📞 Soporte 304
