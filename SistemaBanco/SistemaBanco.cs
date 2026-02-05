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
            Console.WriteLine("=== SISTEMA BANCARIO ===");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido, " + nombre + ":)");
            Console.WriteLine("Seleccione el tipo de cuenta:");
            Console.WriteLine("1. Cuenta de Ahorro");
            Console.WriteLine("2. Cuenta Corriente");
            Console.Write("Opción: ");
            string tipoCuenta = Console.ReadLine();
            Console.Clear();

            Cuenta cuenta;

            if (tipoCuenta == "1")
            {
                cuenta = new CuentaAhorro(nombre, 0.05);
            }
            else
            {
                cuenta = new CuentaCorriente(nombre, 500);
            }

                while (true)
                {
                    Console.WriteLine("=== SISTEMA BANCARIO ===");
                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Retirar");
                    Console.WriteLine("3. Saldo actual");

                if (cuenta is CuentaAhorro)
                {
                    Console.WriteLine("4. Aplicar interés");
                }
                       
                    Console.WriteLine("5. Salir");
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
                        cuenta.Depositar(deposito);
                        cuenta.MostrarSaldo();
                        break;

                        case "2":
                            Console.WriteLine("Ha seleccionado Retirar.");
                            Console.Write("Ingrese el monto a retirar: ");
                            double retiro;
                            while (!double.TryParse(Console.ReadLine(), out retiro) || retiro <= 0)
                            {
                                Console.WriteLine("Monto no válido. Ingrese un número mayor que 0:");
                            }
                        cuenta.Retirar(retiro);
                        cuenta.MostrarSaldo();
                        break;

                        case "3":
                            Console.WriteLine("Ha seleccionado Saldo actual.");
                            Console.Write("Su saldo actual es: ");
                            cuenta.MostrarSaldo();
                        break;

                        case "4":
                            if (cuenta is CuentaAhorro cuentaAhorro)
                            {
                                Console.WriteLine("Ha seleccionado Aplicar interés.");
                                cuentaAhorro.AplicarInteres();
                                cuentaAhorro.MostrarSaldo();
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida.");
                            }
                            break;

                        case "5":
                            Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
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
