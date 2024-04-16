using System;
using System.Collections.Generic;

public abstract class Conta
{
    public string NumeroConta { get; private set; }
    public double Saldo { get; protected set; }
    public List<string> HistoricoTransacoes { get; private set; }

    public Conta(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
        HistoricoTransacoes = new List<string>();
        RegistrarTransacao($"Conta criada com saldo inicial de R${saldoInicial}");
    }

    public virtual void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de depósito deve ser positivo.");
        }

        Saldo += valor;
        RegistrarTransacao($"Depósito de R${valor}");
        Console.WriteLine($"Depósito de R${valor} efetuado com sucesso!");
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque deve ser positivo.");
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para o saque.");
        }

        Saldo -= valor;
        RegistrarTransacao($"Saque de R${valor}");
        Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
    }
    public abstract void AplicarTaxa();

    public void ImprimirExtrato()
    {
        Console.WriteLine($"Extrato da conta {NumeroConta}:\n");
        foreach (var transacao in HistoricoTransacoes)
        {
            Console.WriteLine(transacao);
        }
    }

    protected void RegistrarTransacao(string transacao)
    {
        HistoricoTransacoes.Add($"{DateTime.Now} - {transacao}");
    }
}

public class ContaCorrente : Conta
{
    private const double TaxaDeOperacao = 0.25;

    public ContaCorrente(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de depósito deve ser positivo.");
        }

        Saldo += valor;
        RegistrarTransacao($"Depósito de R${valor}");
        Console.WriteLine($"Depósito de R${valor} efetuado com sucesso!");
    }

    public override void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque deve ser positivo.");
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para o saque.");
        }

        Saldo -= valor;
        RegistrarTransacao($"Saque de R${valor}");
        Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
    }

    public override void AplicarTaxa()
    {
        Saldo -= TaxaDeOperacao;
        RegistrarTransacao($"Taxa de operação de R${TaxaDeOperacao} aplicada.");
    }
}