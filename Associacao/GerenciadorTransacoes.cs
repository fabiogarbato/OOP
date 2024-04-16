using System;
using System.Collections.Generic;

public class GerenciadorTransacoes
{
    public List<string> HistoricoTransacoes { get; private set; }

    public GerenciadorTransacoes()
    {
        HistoricoTransacoes = new List<string>();
    }

    public void RegistrarTransacao(double valor, string tipo)
    {
        string transacao = $"{DateTime.Now} - {tipo} de R${valor}";
        HistoricoTransacoes.Add(transacao);
    }
}