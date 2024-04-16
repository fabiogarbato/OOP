public class ContaCorrente : Conta
{
    private const double TaxaDeOperacao = 0.25;

    public ContaCorrente(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
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