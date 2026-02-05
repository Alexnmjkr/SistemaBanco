using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    class Cuenta
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        protected List<string> Movimientos;
        public Cuenta (string titular)
        {
            Titular = titular;
            Saldo = 0;
            Movimientos = new List<string>();
        }

        protected bool MontoValido(double monto)
        {
            return monto > 0;
        }

        public virtual void Depositar(double monto)
        {
            if (!MontoValido(monto))
            {
                Console.WriteLine("El monto debe ser mayor que cero");
            }
            Saldo += monto;
            Movimientos.Add($"Depósito: ${monto}");
            Console.WriteLine("Depósito exitoso. Saldo actual: $" + Saldo);
        } 
        
        public virtual bool Retirar(double monto)
        {
            if (!MontoValido(monto))
            {
                Console.WriteLine("El monto debe ser mayor que cero");
                return false;
            }

            if (monto <= Saldo)
            { Saldo -= monto;
                Movimientos.Add($"Retiro: ${monto}");
                Console.WriteLine("Retiro realizado correctamente");
                return true;
            }

            Console.WriteLine("Fondos insuficientes.");
            return false;
        }

        public void MostrarSaldo ()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo actual: ${Saldo}");
        }

        public void MostrarMovimientos()
        {
            Console.WriteLine("Movimientos:");
            if (Movimientos.Count == 0)
            {
                Console.WriteLine("No se registraron movimientos");
            }

            foreach (string mov in Movimientos)
            {
                Console.WriteLine(mov);
            }
        }
    }
}
