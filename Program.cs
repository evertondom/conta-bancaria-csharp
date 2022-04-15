using System;
using System.Threading;

namespace Ctasks2
{
    class Conta {
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }       
        public int NumeroConta { get; set; }

        public Conta(int numeroConta, string nomeTitular, double saldo) { 
            NomeTitular = nomeTitular;
            Saldo = saldo;
            NumeroConta = numeroConta;
        }

        public Conta()
        {
        }

        public double VerSaldo() {
            return Saldo;
        }
        
        public void Depositar(double valor) {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} Realizado com Sucesso");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Sacar(double valor) {
            
            if (valor <= Saldo) //saque com taxa de 5.0
            {
                Saldo = (Saldo - 5) - valor;
                Console.WriteLine($"Saque de R${valor} Realizado com Sucesso");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
                Console.WriteLine("Saque Não Foi Realizado, Pois Não Há Saldo Suficiente na Conta");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();


            Console.WriteLine();
            Console.WriteLine("Bem vindo ao banco BCB");
            Console.WriteLine();
            Console.Write("Digite o Número da Conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Titular: ");
            conta.NomeTitular = Console.ReadLine();
            Console.Write("Deseja realizar o Primeiro Deposito? [s/n]: ");
            char resp = char.Parse(Console.ReadLine().ToLower());
            Console.Clear();
            if (resp == 's') {
                Console.Write("Qual o valor do Primeiro Depósito: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);
                Console.Clear();
            }
            
            Console.WriteLine("Conta Cadastrada!");
            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
            Console.WriteLine($"Nome do Titular: {conta.NomeTitular}");
            Console.WriteLine($"Saldo Atual: {conta.Saldo}");
            Thread.Sleep(2500);
            Console.Clear();
            Console.Write("Digite o Valor do Depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);
            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
            Console.WriteLine($"Nome do Titular: {conta.NomeTitular}");
            Console.WriteLine($"Saldo Atual: {conta.Saldo}");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o Valor do Saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Sacar(saque);
            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
            Console.WriteLine($"Nome do Titular: {conta.NomeTitular}");
            Console.WriteLine($"Saldo Atual: {conta.Saldo}");
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Obrigado pela confiança em nosso Banco! :)");




        }
    }
}
