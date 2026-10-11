# Calculadora Multifuncional en C#

Aplicación de consola desarrollada en C# orientada a resolver operaciones aritméticas básicas y determinar el estado académico de un estudiante según su promedio de notas.

---

## Características del Programa

1. **Operaciones Básicas:**
   - Suma (`+`)
   - Resta (`-`)
   - Multiplicación (`*`)
   - División (`/`) con control de división entre cero.

2. **Evaluación de Estudiante:**
   - Solicita 4 calificaciones dentro de una escala de 0 a 100 puntos.
   - Calcula el promedio general.
   - Determina automáticamente si el alumno está **APROBADO** (nota igual o superior a 70) o **REPROBADO** (menor a 70).

3. **Control y Robustez:**
   - **Bucle interactivo continuo:** El programa se mantiene en ejecución mediante un ciclo `while` hasta que el usuario elija expresamente la opción de salir (opción 6).
   - **Validación de entradas:** Mediante `double.TryParse`, el programa previene caídas inesperadas si se ingresan letras o caracteres no numéricos.
   - **Control de rangos:** Las notas deben encontrarse obligatoriamente entre 0 y 100 puntos.

---

## Estructuras de Control Empleadas

- **`while`**: Controla el ciclo principal del menú y las rutinas de validación repetitiva.
- **`switch`**: Gestiona las opciones del menú de forma limpia y directa.
- **`for`**: Itera ordenadamente en la captura de las 4 calificaciones del estudiante.
- **`if / else`**: Valida divisiones entre cero, rangos numéricos y la condición de aprobación final.

---

## Cómo Ejecutar el Proyecto

### Opción 1: Con el SDK de .NET (Visual Studio / VS Code / Terminal)
Si tienes instalado .NET (versión 6, 7, 8 o superior):
```bash
dotnet run
```

### Opción 2: Compilación directa en Windows (sin instalar programas extras)
Windows incluye el compilador nativo de C# (`csc.exe`). Puedes compilarlo abriendo la terminal en la carpeta del proyecto y ejecutando:
```powershell
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" /out:Calculadora.exe Program.cs
.\Calculadora.exe
```
