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

    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);

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
    public ContaCorrente(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        // Lógica específica para depósito em ContaCorrente
        Saldo += valor;
        RegistrarTransacao($"Depósito de R${valor}");
    }

    public override void Sacar(double valor)
    {
        // Lógica específica para saque em ContaCorrente
        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        Saldo -= valor;
        RegistrarTransacao($"Saque de R${valor}");
    }
}