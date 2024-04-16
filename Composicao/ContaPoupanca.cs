public class ContaPoupanca : Conta
{
    private const double TaxaDeRendimento = 0.005;

    public ContaPoupanca(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
        RegistrarTransacao(valor, "Depósito");
    }

    public override void Sacar(double valor)
    {
        Saldo -= valor;
        RegistrarTransacao(valor, "Saque");
    }
}