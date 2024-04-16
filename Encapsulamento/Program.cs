using System;

class Program
{
    static void Main()
    {
        try
        {
            ContaBancaria minhaConta = new ContaBancaria("12345-6", 1000);
            Console.WriteLine($"Saldo inicial: R${minhaConta.Saldo}");

            minhaConta.Depositar(500);
            minhaConta.Sacar(250);
            minhaConta.ImprimirExtrato();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}