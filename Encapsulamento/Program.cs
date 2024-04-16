using System;

class Program
{
    static void Main()
    {
        ContaBancaria minhaConta = new ContaBancaria("12345-6", 1000);
        Console.WriteLine($"Saldo inicial: R${minhaConta.GetSaldo()}");
        Console.WriteLine("-------------------------------------------");

        minhaConta.Depositar(500);
        Console.WriteLine($"Saldo após depósito: R${minhaConta.GetSaldo()}");
        Console.WriteLine("-------------------------------------------");

        minhaConta.Sacar(250);
        Console.WriteLine($"Saldo após saque: R${minhaConta.GetSaldo()}");
        Console.WriteLine("-------------------------------------------");
    }
}
