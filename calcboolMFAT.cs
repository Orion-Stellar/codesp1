using System;

class Calculadora
{
    static void Main()
    {
        bool seguir = true;

        while (seguir)
        {
            Console.Write("Ingrese el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese un operador (+, -, *, /): ");
            string operador = Console.ReadLine();

            Console.Write("Ingrese el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            bool operacionValida = true;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        operacionValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    operacionValida = false;
                    break;
            }

            if (operacionValida)
            {
                Console.WriteLine("Resultado: " + resultado);
            }

            Console.Write("¿Desea hacer otra operación? (true/false): ");
            string respuestaTexto = Console.ReadLine();
            bool.TryParse(respuestaTexto, out seguir);  
        }

        Console.WriteLine("Gracias por usarme.");
    }
}
