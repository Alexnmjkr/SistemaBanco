using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0; //Representa el dinero en la cuenta bancaria

            while (true)
            {
                Console.WriteLine("=== SISTEMA BANCARIO ===");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Saldo actual");
                Console.WriteLine("4. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ha seleccionado Depositar.");
                        Console.Write("Ingrese el monto a depositar: ");
                        double deposito;
                        while (!double.TryParse(Console.ReadLine(), out deposito) || deposito <= 0)
                        {
                            Console.WriteLine("Monto no válido. Ingrese un número mayor que 0:");
                        }
                        saldo += deposito;
                        Console.WriteLine("Saldo actual: $" + saldo);
                        break;

                    case "2":
                        Console.WriteLine("Ha seleccionado Retirar.");
                        Console.Write("Ingrese el monto a retirar: ");
                        double retiro;
                        while (!double.TryParse(Console.ReadLine(), out retiro) || retiro <= 0)
                        {
                            Console.WriteLine("Monto no válido. Ingrese un número mayor que 0:");
                        }

                        if (retiro > saldo)
                        {
                            Console.WriteLine("Fondos insuficientes. Saldo actual: $" + saldo);
                        }
                        else
                        {
                            saldo -= retiro;
                            Console.WriteLine("Retiro exitoso. Saldo actual: $" + saldo);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Ha seleccionado Saldo actual.");
                        Console.WriteLine("Su saldo actual es: $" + saldo);
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del sistema.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
