using System;
namespace PrimeiroProjeto
{
    class Program
{
static void Main(string[]args)
{
    ContaCorrente conta_do_igor = new ContaCorrente();("Igor",1234,908,100000);
    ContaCorrente conta_da_isabela = new ContaCorrente();("Isabela",1234,745,100000);
    ContaCorrente conta_do_nicolau = new ContaCorrente();("Nicolau",1234,751,100000);
    
    Console.WriteLine("A conta é do(a) " + conta_do_igor.Titular  + " da agência " + conta_do_igor.Agencia  + " e do número " + conta_do_igor.Numero  + ".");
    Console.WriteLine("A conta é do(a) " + conta_da_isabela.Titular  + " da agência " + conta_da_isabela.Agencia  + " e da número " + conta_da_isabela.Numero  + ".");
    Console.WriteLine("A conta é do(a) " + conta_do_nicolau.Titular  + " da agência " + conta_do_nicolau.Agencia  + " e do número " + conta_do_nicolau.Numero  + ".");
    
   }
 }
}