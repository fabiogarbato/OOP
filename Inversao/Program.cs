class Program
{
    static void Main()
    {
        IGerenciadorTransacoes gerenciadorCorrente = new GerenciadorTransacoes();
        IGerenciadorTransacoes gerenciadorPoupanca = new GerenciadorTransacoes();

        IConta contaCorrente = new ContaCorrente("12345-6", 1000, gerenciadorCorrente);
        IConta contaPoupanca = new ContaPoupanca("78910-1", 1500, gerenciadorPoupanca);

        contaCorrente.Depositar(500);
        contaCorrente.Sacar(200);
        contaCorrente.ImprimirExtrato();

        contaPoupanca.Depositar(300);
        contaPoupanca.Sacar(100);
        contaPoupanca.ImprimirExtrato();
    }
}
