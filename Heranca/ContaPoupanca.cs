public class ContaPoupanca : Conta
{
    private const double TaxaRendimento = 0.005; 

    public ContaPoupanca(string numeroConta, double saldoInicial) : base(numeroConta, saldoInicial)
    {
    }

    public override void Depositar(double valor)
    {
        Saldo += valor;
        RegistrarTransacao($"Depósito de R${valor}");
    }

    public override void Sacar(double valor)
    {
        Saldo -= valor;
        RegistrarTransacao($"Saque de R${valor}");
    }

    public void AplicarRendimento()
    {
        double rendimento = Saldo * TaxaRendimento;
        Saldo += rendimento;
        RegistrarTransacao($"Rendimento aplicado de R${rendimento}");
    }
}