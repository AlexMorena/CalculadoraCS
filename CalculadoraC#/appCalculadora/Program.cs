using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora en C# ===");
            Console.WriteLine("Operaciones disponibles: +, -, *, /");
            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el operador (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            bool operacionValida = true;

            switch (operador)
            {
                case '+': resultado = num1 + num2; break;
                case '-': resultado = num1 - num2; break;
                case '*': resultado = num1 * num2; break;
                case '/':
                    if (num2 != 0) resultado = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        operacionValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Operador no válido.");
                    operacionValida = false;
                    break;
            }

            if (operacionValida)
            {
                Console.WriteLine($"\nResultado: {num1} {operador} {num2} = {resultado}");
            }

            Console.Write("\n¿Deseas hacer otro cálculo? (S/N): ");
            char respuesta = Console.ReadKey().KeyChar;
            if (char.ToUpper(respuesta) != 'S') break;
        }
    }
}

