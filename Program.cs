using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                LimpiarConsola();

                Console.WriteLine("========================================");
                Console.WriteLine("       CALCULADORA MULTIFUNCIONAL       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Calcular si un estudiante aprobo o no");
                Console.WriteLine("6. Salir");
                Console.WriteLine("========================================");
                Console.Write("Seleccione una opcion (1-6): ");

                string opcion = Console.ReadLine();
                if (opcion == null) break;

                Console.WriteLine();

                switch (opcion.Trim())
                {
                    case "1":
                        RealizarSuma();
                        break;

                    case "2":
                        RealizarResta();
                        break;

                    case "3":
                        RealizarMultiplicacion();
                        break;

                    case "4":
                        RealizarDivision();
                        break;

                    case "5":
                        CalcularAprobacionEstudiante();
                        break;

                    case "6":
                        Console.WriteLine("Gracias por utilizar el programa. Hasta luego!");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Por favor elija un numero del 1 al 6.");
                        break;
                }

                if (continuar)
                {
                    Pausar();
                }
            }
        }

        static void RealizarSuma()
        {
            Console.WriteLine("--- SUMA ---");
            double num1 = PedirNumero("Ingrese el primer numero: ");
            double num2 = PedirNumero("Ingrese el segundo numero: ");
            double resultado = num1 + num2;
            Console.WriteLine("\nResultado: {0} + {1} = {2}", num1, num2, resultado);
        }

        static void RealizarResta()
        {
            Console.WriteLine("--- RESTA ---");
            double num1 = PedirNumero("Ingrese el primer numero: ");
            double num2 = PedirNumero("Ingrese el segundo numero: ");
            double resultado = num1 - num2;
            Console.WriteLine("\nResultado: {0} - {1} = {2}", num1, num2, resultado);
        }

        static void RealizarMultiplicacion()
        {
            Console.WriteLine("--- MULTIPLICACION ---");
            double num1 = PedirNumero("Ingrese el primer numero: ");
            double num2 = PedirNumero("Ingrese el segundo numero: ");
            double resultado = num1 * num2;
            Console.WriteLine("\nResultado: {0} * {1} = {2}", num1, num2, resultado);
        }

        static void RealizarDivision()
        {
            Console.WriteLine("--- DIVISION ---");
            double num1 = PedirNumero("Ingrese el dividendo (primer numero): ");
            double num2 = PedirNumero("Ingrese el divisor (segundo numero): ");

            if (num2 == 0)
            {
                Console.WriteLine("\nError: No se puede dividir entre cero.");
            }
            else
            {
                double resultado = num1 / num2;
                Console.WriteLine("\nResultado: {0} / {1} = {2:F2}", num1, num2, resultado);
            }
        }

        static void CalcularAprobacionEstudiante()
        {
            Console.WriteLine("--- EVALUACION DE ESTUDIANTE ---");
            Console.WriteLine("Calcularemos el promedio de 4 calificaciones (Escala de 0 a 100).");
            Console.WriteLine("La nota minima para aprobar es de 70 puntos.\n");

            double sumaNotas = 0;
            int totalCalificaciones = 4;

            for (int i = 1; i <= totalCalificaciones; i++)
            {
                string mensajeNota = string.Format("Ingrese la calificacion #{0} (0 - 100): ", i);
                double nota = PedirCalificacionValida(mensajeNota);
                sumaNotas += nota;
            }

            double promedio = sumaNotas / totalCalificaciones;

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Promedio obtenido: {0:F2} puntos", promedio);

            if (promedio >= 70)
            {
                Console.WriteLine("Estado: APROBADO");
                Console.WriteLine("Felicidades, el estudiante supero la nota minima requerida.");
            }
            else
            {
                Console.WriteLine("Estado: REPROBADO");
                Console.WriteLine("El estudiante no alcanzo el puntaje minimo de 70 puntos.");
            }
            Console.WriteLine("----------------------------------------");
        }

        static double PedirNumero(string mensaje)
        {
            double numero;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (entrada == null) return 0;

                if (double.TryParse(entrada.Trim(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un valor numerico valido (ejemplo: 10, 25.5).");
                }
            }
        }

        static double PedirCalificacionValida(string mensaje)
        {
            while (true)
            {
                double nota = PedirNumero(mensaje);

                if (nota >= 0 && nota <= 100)
                {
                    return nota;
                }
                else
                {
                    Console.WriteLine("Error: La calificacion debe estar entre 0 y 100.");
                }
            }
        }

        static void LimpiarConsola()
        {
            try
            {
                if (!Console.IsOutputRedirected)
                {
                    Console.Clear();
                }
            }
            catch
            {
            }
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla o Enter para continuar...");
            try
            {
                if (!Console.IsInputRedirected)
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.ReadLine();
            }
        }
    }
}
