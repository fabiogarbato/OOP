public class GerenciadorTransacoes : IGerenciadorTransacoes
{
    private List<string> historicoTransacoes = new List<string>();

    public void RegistrarTransacao(double valor, string tipo)
    {
        historicoTransacoes.Add($"{DateTime.Now} - {tipo} de R${valor}");
    }

    public void ImprimirHistorico()
    {
        foreach (var transacao in historicoTransacoes)
        {
            Console.WriteLine(transacao);
        }
    }
}

public abstract class Conta : IConta
{
    public string NumeroConta { get; private set; }
    public double Saldo { get; protected set; }
    protected IGerenciadorTransacoes gerenciador;  // Alterado para 'protected'

    public Conta(string numeroConta, double saldoInicial, IGerenciadorTransacoes gerenciador)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
        this.gerenciador = gerenciador;
        this.gerenciador.RegistrarTransacao(saldoInicial, "Conta criada com saldo inicial");
    }

    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);

    public void ImprimirExtrato()
    {
        Console.WriteLine($"Extrato da conta {NumeroConta}:\n");
        gerenciador.ImprimirHistorico();
    }
}

public class ContaCorrente : Conta
{
    public ContaCorrente(string numeroConta, double saldoInicial, IGerenciadorTransacoes gerenciador)
        : base(numeroConta, saldoInicial, gerenciador)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
        gerenciador.RegistrarTransacao(valor, "Depósito");
    }

    public override void Sacar(double valor)
    {
        Saldo -= valor;
        gerenciador.RegistrarTransacao(valor, "Saque");
    }
}

public class ContaPoupanca : Conta
{
    public ContaPoupanca(string numeroConta, double saldoInicial, IGerenciadorTransacoes gerenciador)
        : base(numeroConta, saldoInicial, gerenciador)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
        gerenciador.RegistrarTransacao(valor, "Depósito");
    }

    public override void Sacar(double valor)
    {
        Saldo -= valor;
        gerenciador.RegistrarTransacao(valor, "Saque");
    }
}
