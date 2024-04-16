using System;
using System.Collections.Generic;

public class ContaBancaria
{
    private string numeroConta;
    private double saldo;
    private List<string> historicoTransacoes;

    public ContaBancaria(string numero, double saldoInicial)
    {
        NumeroConta = numero;
        saldo = saldoInicial;
        historicoTransacoes = new List<string>();
        RegistrarTransacao($"Conta criada com saldo inicial de R${saldoInicial}");
    }

    public string NumeroConta
    {
        get { return numeroConta; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O número da conta não pode ser vazio.");
            }
            numeroConta = value;
        }
    }

    public double Saldo
    {
        get { return saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de depósito deve ser positivo.");
        }

        saldo += valor;
        RegistrarTransacao($"Depósito de R${valor}");
        Console.WriteLine($"Depósito de R${valor} efetuado com sucesso!");
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque deve ser positivo.");
        }

        if (valor > saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para o saque.");
        }

        saldo -= valor;
        RegistrarTransacao($"Saque de R${valor}");
        Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
    }

    public void ImprimirExtrato()
    {
        Console.WriteLine($"Extrato da conta {NumeroConta}:\n");
        foreach (var transacao in historicoTransacoes)
        {
            Console.WriteLine(transacao);
        }
    }

    private void RegistrarTransacao(string transacao)
    {
        historicoTransacoes.Add($"{DateTime.Now} - {transacao}");
    }
}