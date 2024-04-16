public abstract class Conta
{
    public string NumeroConta { get; private set; }
    public double Saldo { get; protected set; }
    public Cliente Cliente { get; private set; }
    private GerenciadorTransacoes gerenciador;

    public Conta(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
        gerenciador = new GerenciadorTransacoes();
        RegistrarTransacao(saldoInicial, "Conta criada com saldo inicial");
    }

    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);

    public void DefinirCliente(Cliente cliente)
    {
        Cliente = cliente;
    }

    public void ImprimirExtrato()
    {
        Console.WriteLine($"Extrato da conta {NumeroConta} do cliente {Cliente.Nome}:\n");
        foreach (var transacao in gerenciador.HistoricoTransacoes)
        {
            Console.WriteLine(transacao);
        }
    }

    protected void RegistrarTransacao(double valor, string tipo)
    {
        gerenciador.RegistrarTransacao(valor, tipo);
    }
}