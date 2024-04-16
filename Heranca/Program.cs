using System;
class Program
{
    static void Main()
    {
        ContaCorrente contaCorrente = new ContaCorrente("CC12345-6", 1000);
        ContaPoupanca contaPoupanca = new ContaPoupanca("CP12345-6", 1000);

        contaCorrente.Depositar(200);
        contaCorrente.Sacar(100);
        contaCorrente.ImprimirExtrato();

        contaPoupanca.Depositar(200);
        contaPoupanca.AplicarRendimento();
        contaPoupanca.ImprimirExtrato();
    }
}