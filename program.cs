using System;
using Course;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("digite o nome do usuario: ");
            string titular = Console.ReadLine();
            Console.Write("Deseja fazer algum deposito? (S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor que sera depositado: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para ser depositado: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Dados da saque: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para ser depositado: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}