using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancária 
{ 
    public class Conta{
        private float saldo_limite;

        private string? Num_conta { get; set; }
        private float Saldo { get; set; }
        private float Limite { get; set; }

        public float consulta_saldo()
        {
            return Saldo;
        }

        public void deposito(float valor_deposito)
        {
            Saldo += valor_deposito;
            Console.WriteLine("Agora seu depósito é de R$ " + consulta_saldo());
        }

        public void sacar(float valor_saque)
        {
            if (valor_saque > saldo_limite)
            {
                Console.WriteLine("VOCÊ NÃO TEM SALDO O SUFICIENTE!");
            }
            else
            {
                Saldo -= valor_saque;
                Console.WriteLine("Agora seu saldo é de R$ " + consulta_saldo());
            }
        }

        public void ajustar_limite(float valor_limite)
        {
            Limite = valor_limite;
            Console.WriteLine("Agora seu limite é de R$ " + Limite);
            saldo_limite = Limite + Saldo;
            Console.WriteLine("Seu saldo + limite é de R$ " + saldo_limite);
        }
    }
}