using System;

class Program
{
    static void Main()
    {
        try
        {
            List<Conta> contas = new List<Conta>
            {
                new ContaCorrente("12345-6", 1000),
                new ContaPoupanca("67890-1", 1500)
            };

            foreach (var conta in contas)
            {
                conta.Depositar(200);
                conta.Sacar(100);
                conta.AplicarTaxa();
                conta.ImprimirExtrato();
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}