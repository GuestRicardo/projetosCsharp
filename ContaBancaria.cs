
using System.Globalization;


namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5;//taxa de manutencao
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }

}

