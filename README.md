# Exphadis.Core.Contract

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/download)
[![License](https://img.shields.io/badge/license-Proprietary-blue.svg)](LICENSE)

Biblioteca de contratos, DTOs, mappers y validadores para el sistema Exphadis. Este paquete define las estructuras de datos y reglas de validación utilizadas en la comunicación entre capas de la aplicación.

## 📋 Tabla de Contenidos

- [Características](#-características)
- [Requisitos](#-requisitos)
- [Instalación](#-instalación)
- [Uso](#-uso)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [DTOs Disponibles](#-dtos-disponibles)
- [Validadores](#-validadores)
- [Mappers](#-mappers)
- [Dependencias](#-dependencias)
- [Contribuir](#-contribuir)

## ✨ Características

- **DTOs**: Objetos de transferencia de datos para todas las entidades del sistema
- **Validadores**: Validación automática usando FluentValidation
- **Mappers**: Configuración de AutoMapper para conversión entre entidades y DTOs
- **Enumeraciones**: Tipos enumerados compartidos
- **Excepciones**: Excepciones personalizadas del dominio
- **Extensiones**: Métodos de extensión para registro de servicios

## 📦 Requisitos

- .NET 8.0 o superior
- AutoMapper 12.0.1+
- FluentValidation 11.9.0+

## 🚀 Instalación

### Desde NuGet (Producción)

```bash
dotnet add package Exphadis.Core.Contract
```

### Desarrollo Local

```bash
# Clonar el repositorio
git clone https://github.com/walberth/exphadis-core-contract.git
cd exphadis-core-contract

# Restaurar dependencias
dotnet restore

# Compilar
dotnet build
```

## 💻 Uso

### Registro de Servicios

En tu `Program.cs` o `Startup.cs`:

```csharp
using Exphadis.Core.Contract;

// En ConfigureServices
services.AddContractsDependency();
```

Esto registra automáticamente:
- Perfiles de AutoMapper
- Validadores de FluentValidation

### Uso de DTOs

```csharp
using Exphadis.Core.Contract.Dto;

// Crear un DTO de estudiante
var studentDto = new StudentDto
{
    Id = Guid.NewGuid(),
    FirstName = "Juan",
    LastName = "Pérez",
    Email = "juan.perez@ejemplo.com"
};
```

### Validación

```csharp
using FluentValidation;

public class MyService
{
    private readonly IValidator<StudentDto> _validator;

    public MyService(IValidator<StudentDto> validator)
    {
        _validator = validator;
    }

    public async Task<bool> ValidateStudent(StudentDto student)
    {
        var result = await _validator.ValidateAsync(student);
        return result.IsValid;
    }
}
```

### Mapping

```csharp
using AutoMapper;

public class StudentService
{
    private readonly IMapper _mapper;

    public StudentService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public StudentDto ConvertToDto(Student entity)
    {
        return _mapper.Map<StudentDto>(entity);
    }
}
```

## 📁 Estructura del Proyecto

```
exphadis-core-contract/
├── Dto/                          # Objetos de transferencia de datos
│   ├── Base/                     # DTOs base
│   ├── StudentDto.cs
│   ├── UserDto.cs
│   ├── PaymentDto.cs
│   └── ...
├── Enums/                        # Enumeraciones
├── Exception/                    # Excepciones personalizadas
├── Mapper/                       # Perfiles de AutoMapper
│   ├── AuthenticationProfile.cs
│   ├── StudentProfile.cs
│   └── ...
├── Validator/                    # Validadores FluentValidation
├── ServiceExtension.cs           # Extensiones de DI
└── GlobalUsing.cs               # Using globales

```

## 📊 DTOs Disponibles

### Gestión Académica
- `StudentDto` - Información de estudiantes
- `EnrollmentDto` - Matrículas
- `CourseDto` - Cursos
- `SubjectDto` - Asignaturas
- `QualificationDto` - Calificaciones
- `CertificateCourseDto` - Certificados

### Gestión de Pagos
- `PaymentDto` - Pagos
- `PaymentPlanDto` - Planes de pago
- `BankPaymentDto` - Pagos bancarios
- `VoucherPaymentDto` - Comprobantes
- `MoneyMovementDto` - Movimientos financieros

### Gestión de Usuarios
- `UserDto` - Usuarios del sistema
- `RoleDto` - Roles
- `PermissionDto` - Permisos
- `SessionDto` - Sesiones

### Gestión de Personal
- `WorkerDto` - Trabajadores
- `WorkerPaymentDto` - Pagos a trabajadores
- `WorkerEvaluationDto` - Evaluaciones

### Otros
- `NotificationDto` - Notificaciones
- `LogDto` - Registros de auditoría
- `MediaDto` - Archivos multimedia
- `EmailDto` - Correos electrónicos

Ver la carpeta `Dto/` para la lista completa.

## ✅ Validadores

Los validadores se registran automáticamente y validan:

- Campos requeridos
- Formatos de email
- Longitudes de cadenas
- Rangos numéricos
- Reglas de negocio específicas

Ejemplo de validación personalizada:

```csharp
public class StudentDtoValidator : AbstractValidator<StudentDto>
{
    public StudentDtoValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
        
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100);
    }
}
```

## 🗺️ Mappers

Perfiles de AutoMapper disponibles:

- `AuthenticationProfile` - Login y autenticación
- `UserProfile` - Usuarios
- `StudentProfile` - Estudiantes
- `PaymentProfile` - Pagos
- `WorkerProfile` - Trabajadores
- `NoteProfile` - Calificaciones
- `CourseProfile` - Cursos
- `TutorshipProfile` - Tutorías
- `EnrollmentProfile` - Matrículas
- `MasterDataProfile` - Datos maestros
- `AttorneyProfile` - Apoderados

## 📚 Dependencias

```xml
<PackageReference Include="AutoMapper" Version="12.0.1" />
<PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.9.0" />
<PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="9.0.10" />
<PackageReference Include="Microsoft.Extensions.Logging" Version="9.0.10" />
<PackageReference Include="Microsoft.AspNetCore.Http.Abstractions" Version="2.3.0" />
<PackageReference Include="Walberth.Helper" Version="0.*" />
<PackageReference Include="Exphadis.Core.Domain" Version="0.*" />
```

## 🤝 Contribuir

Este es un proyecto privado de Exphadis. Para contribuir:

1. Crear una rama desde `main`
2. Realizar los cambios necesarios
3. Asegurar que todas las pruebas pasen
4. Crear un Pull Request

### Convenciones de Código

- Usar PascalCase para nombres de clases y propiedades
- Incluir validadores para todos los DTOs nuevos
- Documentar propiedades públicas con comentarios XML
- Seguir los principios SOLID

## 📝 Licencia

Copyright (c) 2025 Exphadis. Todos los derechos reservados.

Este es un proyecto privado y propietario.

## 👥 Autores

- **Walberth** - [walberth](https://github.com/walberth)

## 📞 Soporte

Para preguntas o soporte, contactar al equipo de desarrollo de Exphadis.

---

**Nota**: Este paquete es parte del ecosistema Exphadis y debe usarse junto con `Exphadis.Core.Domain` y otros paquetes relacionados.