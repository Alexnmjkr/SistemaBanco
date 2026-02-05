using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    class CuentaCorriente : Cuenta
    {
        public double LimiteSobregiro { get; set; }
        public double LimiteDescubierto { get; set; }
        public CuentaCorriente(string titular, double limiteDescubierto)
            : base(titular)
        {
            LimiteDescubierto = limiteDescubierto;
        }
        //Sobrescribe el método Retirar de la clase base
        public override bool Retirar(double monto)
        {
            if (monto <= Saldo + LimiteSobregiro)
            {
                Saldo -= monto;
                Movimientos.Add($"Retiro: ${monto}");
                Console.WriteLine("Retiro realizado (con sobregiro si aplica).");
                return true;
            }

            Console.WriteLine("Límite de sobregiro excedido.");
            return false;
        }
    }
}
