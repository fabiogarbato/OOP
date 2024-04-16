public class ContaPoupanca : Conta
{
    private const double TaxaDeRendimento = 0.005; 

    public ContaPoupanca(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        base.Depositar(valor);
    }

    public override void Sacar(double valor)
    {
        base.Sacar(valor);
    }

    public override void AplicarTaxa()
    {
        double rendimento = Saldo * TaxaDeRendimento;
        Saldo += rendimento;
        RegistrarTransacao($"Rendimento de R${rendimento} aplicado.");
    }
}