using System;

namespace meuPrimeiroProjeto
{
    class Program
    {  
        static void Main(string[] args)
        {
            ContaCorrente conta_do_igor = new ContaCorrente ("Igor", 12345, 123, 1000);
            ContaCorrente conta_do_nicolau = new ContaCorrente ("Nicolau", 12345, 789, 1000);
            ContaCorrente conta_do_joao = new ContaCorrente ("Joao", 12345, 456, 1000);
           
            Console.WriteLine("A conta é do (a) " + conta_do_igor.Titular + 
            ", a agência é " + conta_do_igor.Agencia + " o número é " 
            + conta_do_igor.Numero + " e o Saldo " + conta_do_igor.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + conta_do_nicolau.Titular + 
            ", a agência é " + conta_do_nicolau.Agencia + " o número é " 
            + conta_do_nicolau.Numero + " e o Saldo " + conta_do_nicolau.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + conta_do_joao.Titular + 
            ", a agência é " + conta_do_joao.Agencia + " o número é " 
            + conta_do_joao.Numero + " e o Saldo " + conta_do_joao.Saldo + ".");

            bool sacar_conta = conta_do_igor.Sacar(100);
            bool sacar_conta1 = conta_do_joao.Sacar(100);
            bool sacar_conta2 = conta_do_nicolau.Sacar(100);
            
             Console.WriteLine("A conta é do (a) " + conta_do_igor.Titular + 
            ", a agência é " + conta_do_igor.Agencia + " o número é " 
            + conta_do_igor.Numero + " e o Saldo " + conta_do_igor.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + conta_do_nicolau.Titular + 
            ", a agência é " + conta_do_nicolau.Agencia + " o número é " 
            + conta_do_nicolau.Numero + " e o Saldo " + conta_do_nicolau.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + conta_do_joao.Titular + 
            ", a agência é " + conta_do_joao.Agencia + " o número é " 
            + conta_do_joao.Numero + " e o Saldo " + conta_do_joao.Saldo + ".");
        }
    }
}
