//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Contracts;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sistema_Bancario
//{
//    public class ContaBancaria : Icontabancaria
//    {

//        private double saldo;
//        public string titular;
//        public static int proximoNumero = 0;
//        public int numeroConta;

//        //metodo construtor que constroi o nosso objeto
//        public ContaBancaria(string titularRecebido)
//        {
//            //cria o obejto conta bancaria com o titular sendo o valor recebido
//            titular = titularRecebido;
//            //primero ele adiciona um de depois salva o numero da conta proximoNumero + 1
//            numeroConta = ++proximoNumero;
//            //primero ele salva o numero da conta e depois adiciona 1  
//            //numeroConta = proximaNuemro++
//            //saldo
//            saldo = 0;
//        }
//        public void ConsultarSaldo()
//        {
//            Console.WriteLine($"Conta: {numeroConta} | Titula : {titular} | Saldo: R$ {saldo:f2}");
//        }

//        public virtual void Depositar(double valor)
//        {
//            //saldo = saldo + valor;
//            saldo += valor;
//            Console.WriteLine($"Deposito de R $ {valor:f2} realizado.\nSaldo atual : R${saldo:f2}");
//        }

//        public bool Sacar(double valor)
//        {
//            if (valor > saldo)
//            {
//                Console.WriteLine("Saldo insuficiente");
//                return false;
//            }
//            else
//            {
//                //saldo = saldo - valor
//                saldo -= valor;
//                Console.WriteLine($"Saque de R$ {valor:f2}
//                realizado.\nSaldo atual: R${ saldo: f2}");
//                return false;
//                //Console.WriteLine($"Saque de R$ {valor:f2}
//                //    realizado.\nSaldo atual : R${saldo:f2}");
//                //    return true;
//            }
//        }
//    }
//}
using System;

namespace Sistema_Bancario
{
    public class ContaBancaria : Icontabancaria
    {
        private double saldo;
        public string titular;
        public static int proximoNumero = 0;
        public int numeroConta;

        // Construtor
        public ContaBancaria(string titularRecebido)
        {
            titular = titularRecebido;
            numeroConta = ++proximoNumero;
            saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Conta: {numeroConta} | Titular: {titular} | Saldo: R$ {saldo:F2}");
        }

        public virtual void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado.\nSaldo atual: R$ {saldo:F2}");
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado.\nSaldo atual: R$ {saldo:F2}");
                return true;
            }
        }
    }
}
