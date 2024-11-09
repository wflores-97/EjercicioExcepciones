namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            operaciones Operaciones = new operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        continue;
                    }

                    Console.Write("Ingrese el primer número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = Operaciones.Sumar(numero1, numero2);
                            Console.WriteLine($"Resultado de la suma: {resultado}");
                            break;
                        case 2:
                            resultado = Operaciones.Restar(numero1, numero2);
                            Console.WriteLine($"Resultado de la resta: {resultado}");
                            break;
                        case 3:
                            resultado = Operaciones.Multiplicar(numero1, numero2);
                            Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                            break;
                        case 4:
                            resultado = Operaciones.Dividir(numero1, numero2);
                            Console.WriteLine($"Resultado de la división: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Por favor, ingrese un número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}