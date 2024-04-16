using System;
public class ContaBancaria
{
    private string numeroConta;
    private double saldo;

    public ContaBancaria(string numero, double saldoInicial)
    {
        numeroConta = numero;
        saldo = saldoInicial;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} efetuado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de depósito deve ser positivo.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para o saque.");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
        }
    }
}
