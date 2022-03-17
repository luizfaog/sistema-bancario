using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBancário
{
    public class conta
    {
        public double numeroConta;
        public double agenciaConta;
        public double saldo;
        
        public double Getsaldoatual()
        {
            return saldo;
        }

        public double GetDepósito(double valor)
        {
            saldo = saldo + valor;
            return saldo;
        }
        public double GetSaque(double valor)
        {
            if(valor <= saldo)
            {
                saldo = saldo - valor;
            }
            else
                Console.WriteLine("O valor de saque é maior do que o valor em conta, por favor forneça um valor menor ou igual ao seu saldo!");
            return saldo;
        }
    }
    public class titular
    {
        public string nomeTitular, endereço;
        public int cpfTtitular;
        
    }
}
