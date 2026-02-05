using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    //Usa base(titular) para llamar al constructor de la clase base
    //Accede a Saldo porque es protected
    class CuentaAhorro : Cuenta
    {
        public double TasaInteres { get; set; }
        public CuentaAhorro(string titular, double tasaInteres)
            : base(titular)
        {
            TasaInteres = tasaInteres;
        }
        public void AplicarInteres()
        {
            double interes = Saldo * TasaInteres / 100;
            Saldo += interes;
            Console.WriteLine("Interés aplicado: $" + interes + ". Saldo actual: $" + Saldo);
        }
    }
}
