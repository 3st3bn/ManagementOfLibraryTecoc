# Gestión de Préstamos de Libros en la Biblioteca del TECOC

## Descripción
Este proyecto implementa una aplicación de software para gestionar los préstamos y devoluciones de libros en la biblioteca del TECOC. Permite a los bibliotecarios llevar un registro eficiente y preciso de todos los libros prestados, sus fechas de vencimiento y los usuarios que los tienen.

## Principios SOLID
### S - Single Responsibility Principle
Cada clase tiene una única responsabilidad:
- `Libro` representa un libro en la biblioteca.
- `Usuario` representa un usuario de la biblioteca.
- `Prestamo` representa un préstamo de un libro.
- Servicios (`LibroService`, `UsuarioService`, `PrestamoService`) manejan la lógica de negocio para cada entidad.
- Repositorios (`LibroRepository`, `UsuarioRepository`, `PrestamoRepository`) manejan la persistencia de datos.

### O - Open/Closed Principle
Los servicios y repositorios están abiertos para extensión pero cerrados para modificación. Se pueden agregar nuevas funcionalidades sin modificar el código existente.

### L - Liskov Substitution Principle
Los servicios y repositorios implementan interfaces, permitiendo la sustitución sin afectar la funcionalidad.

### I - Interface Segregation Principle
Las interfaces definen solo los métodos necesarios para cada responsabilidad específica.

### D - Dependency Inversion Principle
Los controladores dependen de abstracciones (interfaces de servicios) en lugar de implementaciones concretas.

## Configuración
1. Clona el repositorio.
   ```bash
   git clone https://github.com/tu-usuario/library-management.git
