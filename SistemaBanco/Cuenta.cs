using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    internal class Cuenta
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Cuenta (string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public virtual void Depositar(double monto)
        {
            Saldo += monto;
            Console.WriteLine("Depósito exitoso. Saldo actual: $" + Saldo);
        } 
        
        public virtual bool Retirar(double monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
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
    }
}
