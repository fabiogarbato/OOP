using System;
using System.Collections.Generic;

public class Cliente
{
    public string Nome { get; private set; }
    public List<Conta> Contas { get; private set; }

    public Cliente(string nome)
    {
        Nome = nome;
        Contas = new List<Conta>();
    }

    public void AdicionarConta(Conta conta)
    {
        Contas.Add(conta);
        conta.DefinirCliente(this);
    }
}