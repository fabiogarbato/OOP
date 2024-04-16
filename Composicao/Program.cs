using System;
class Program
{
    static void Main()
    {
        Conta minhaContaCorrente = new ContaCorrente("12345-6", 1000);
        minhaContaCorrente.Depositar(500);
        minhaContaCorrente.Sacar(200);
        minhaContaCorrente.ImprimirExtrato();

        Conta minhaContaPoupanca = new ContaPoupanca("78910-1", 1500);
        minhaContaPoupanca.Depositar(300);
        minhaContaPoupanca.Sacar(100);
        minhaContaPoupanca.ImprimirExtrato();
    }
}