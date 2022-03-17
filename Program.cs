using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBancário
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new conta();
            
            conta.agenciaConta = 001;
            conta.numeroConta = 4525478315;
            conta.saldo = 2500;

            var titular = new titular();

            titular.cpfTtitular = 01578525471;
            titular.nomeTitular = "Luiz Felipe Alves";
            titular.endereço = "Rua 2, Bairro ABC";
            
            Console.WriteLine("O saldo da conta " + conta.numeroConta + " do titular " + titular.nomeTitular + " é: " + conta.Getsaldoatual());
            
            conta.GetDepósito(850.88);

            Console.WriteLine("O saldo da conta " + conta.numeroConta + " do titular " + titular.nomeTitular + " após o depósito é: " + conta.Getsaldoatual());

            conta.GetDepósito(1200.50);

            Console.WriteLine("O saldo da conta " + conta.numeroConta + " do titular " + titular.nomeTitular + " após o depósito é: " + conta.Getsaldoatual());

            conta.GetSaque(1800);

            Console.WriteLine("O saldo da conta " + conta.numeroConta + " do titular " + titular.nomeTitular + " após o saque é: " + conta.Getsaldoatual());

            conta.GetSaque(2000);

            Console.WriteLine("O saldo da conta " + conta.numeroConta + " do titular " + titular.nomeTitular + " após o saque é: " + conta.Getsaldoatual());

            conta.GetSaque(2000);

            Console.ReadKey();

        }
    }
}
